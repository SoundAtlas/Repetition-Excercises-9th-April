namespace Repetition_Excercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new FullTimeEmployee("Anna", 30000));
            employees.Add(new PartTimeEmployee("Bo", 0, 80));
            employees.Add(new FullTimeEmployee("Carl", 32000));

            foreach (var e in employees)
            {
                e.ShowInfo();
            }
        }

    }
}







