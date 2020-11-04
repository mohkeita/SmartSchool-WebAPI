namespace SmartSchool_WebAPI.Models
{
    public class Teacher
    {
        public Teacher() { }

        public Teacher(int id, string firstname, string subject)
        {
            this.id = id;
            this.firstname = firstname;
            this.subject = subject;
        }

        public int id { get; set; }
        public string firstname { get; set; }
        public string subject { get; set; }
    }
}