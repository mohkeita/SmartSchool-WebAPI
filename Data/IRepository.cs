using System.Threading.Tasks;
using SmartSchool_WebAPI.Models;

namespace SmartSchool_WebAPI.Data
{
    public interface IRepository
    {
        //ALL
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //STUDENT
        Task<Student[]> GetAllStudentsAsync(bool includeTeacher);        
        Task<Student[]> GetStudentsAsyncBySubjectId(int subjectId, bool includeSubject);
        Task<Student> GetStudentAsyncById(int studentId, bool includeTeacher);

        //TEACHER
        Task<Teacher[]> GetAllTeachersAsync(bool includeStudent);
        Task<Teacher> GetTeacherAsyncById(int teacherId, bool includeStudent);
        Task<Teacher[]> GetTeachersAsyncByStudentId(int studentId, bool includeSubject);
    }
}