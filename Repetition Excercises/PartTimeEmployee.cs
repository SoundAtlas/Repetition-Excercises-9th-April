namespace Repetition_Excercises
{
    public class PartTimeEmployee : Employee
    {
        public int Hours { get; set; }

        public PartTimeEmployee(string name, double baseSalary, int hours)
            : base(name, baseSalary)
        {
            Hours = hours;
        }

        public override double CalculateSalary()
        {
            return Hours * 150;
        }

    }
}
