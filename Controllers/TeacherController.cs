using Microsoft.AspNetCore.Mvc;

namespace SmartSchool_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Mohamed");
        }

    }
}