namespace SmartSchool_WebAPI.Models
{
    public class Student
    {
        public Student() { }
        
        public Student(int id, string firstname, string lastname, string phone)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.phone = phone;
        }

        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string phone { get; set; }
    }
    
}