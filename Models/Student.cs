using System.Collections.Generic;

namespace SmartSchool_WebAPI.Models
{
    public class Student
    {
        public Student() { }
        
        public Student(int id, string firstname, string lastname, string phone)
        {
            this.Id = id;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Phone = phone;
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        
        public IEnumerable<StudentSubject> StudentsSubjects { get; set; }
    }
    
}