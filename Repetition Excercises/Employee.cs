namespace Repetition_Excercises
{

    public abstract class Employee
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public Employee(string name, double baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }
        public abstract double CalculateSalary();
        public virtual void ShowInfo()
        {
            Console.WriteLine($"{Name} - Salary: {CalculateSalary()} DKK");
        }
    }
}
