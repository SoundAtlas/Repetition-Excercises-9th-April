namespace Repetition_Excercises.School_System
{
    public class Teacher : Person
    {
        public string Subject { get; set; }
        public Teacher(string name, int age, string subject)
            : base(name, age)
        {
            Subject = subject;
        }
        public override string GetRole()
        {
            return "Teacher";
        }
    }
}
