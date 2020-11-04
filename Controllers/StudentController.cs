using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartSchool_WebAPI.Data;
using SmartSchool_WebAPI.Models;

namespace SmartSchool_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IRepository _repo;

        public StudentController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _repo.GetAllStudentsAsync(true);
                return Ok(result);

            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }
        
        [HttpGet("{StudentId}")]
        public async Task<IActionResult> GetByStudentId(int StudentId)
        {
            try
            {
                var result = await _repo.GetStudentAsyncById(StudentId, true);
                return Ok(result);

            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpGet("BySubject/{subjectId}")]
        public async Task<IActionResult> GetBySubjectId(int subjectId)
        {
            try
            {
                var result = await _repo.GetStudentsAsyncBySubjectId(subjectId, true);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
            
        }
        
        [HttpPost]
        public async Task<IActionResult> post(Student model)
        {
            try
            {
                _repo.Add(model);
                
                if (await _repo.SaveChangesAsync())
                {
                    return Ok(model);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

            return BadRequest();
        }
        
        [HttpPut("{StudentId}")]
        public async Task<IActionResult> put(int studentId,Student model)
        {
            try
            {
                var student = await _repo.GetStudentAsyncById(studentId, false);
                if (student == null) return NotFound();
                
                _repo.Update(model);

                if (await _repo.SaveChangesAsync())
                {
                    return Ok(model);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

            return BadRequest();
        }
        
        [HttpDelete("{StudentId}")]
        public async Task<IActionResult> delete(int studentId)
        {
            try
            {
                var student = await _repo.GetStudentAsyncById(studentId, false);
                if (student == null) return NotFound();
                
                _repo.Delete(student);

                if (await _repo.SaveChangesAsync())
                {
                    return Ok("Deleted");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }

            return BadRequest();
        }
        
    }
}