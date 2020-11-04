using System.Collections.Generic;

namespace SmartSchool_WebAPI.Models
{
    public class Subject
    {
        public Subject() { }

        public Subject(int id, string name, int teacherId)
        {
            Id = id;
            Name = name;
            TeacherId = teacherId;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public IEnumerable<StudentSubject> StudentsSubjects { get; set; }
        
    }
}