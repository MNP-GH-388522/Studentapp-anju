namespace Student_app
{
    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public object Enrolments { get; internal set; }
    }
}
