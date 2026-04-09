namespace Repetition_Excercises.School_System
{
    public class Student : Person
    {
        public string TeamName { get; set; }
        public List<int> Grades { get; set; }

        public Student(string name, int age, string teamName)
            : base(name, age)
        {
            TeamName = teamName;
            Grades = new List<int>();
        }

        public override string GetRole()
        {
            return "Student";
        }

        public void AddGrade(int grade)
        {
            Grades.Add(grade);
        }

        public double CalculateAverage()
        {
            int sum = 0;
            foreach (int grade in Grades)
            {
                sum += grade;
            }

            return (double)sum / Grades.Count;
        }
    }
}
