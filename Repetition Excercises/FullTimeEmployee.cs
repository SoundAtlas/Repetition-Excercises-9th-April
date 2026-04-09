namespace Repetition_Excercises
{
    public class FullTimeEmployee : Employee
    {


        public FullTimeEmployee(string name, double baseSalary)
            : base(name, baseSalary)
        {
        }
        public override double CalculateSalary()
        {
            return BaseSalary + 2000;
        }
    }
}
