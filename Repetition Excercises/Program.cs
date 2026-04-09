namespace Repetition_Excercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Laptop", 999.99);

            Console.WriteLine(product1.ToText());

            bool searchTest = product1.Contains("lap");

            Console.WriteLine(searchTest);
        }

    }
}







