namespace Repetition_Excercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPrintable> products = new List<IPrintable>()
            {
                new Product("Laptop", 999.99),
                new Product("Tower PC", 1999.99),
                new Product("Smartphone", 499.99),
                new Product("Tablet", 299.99)
            };

            PrintAll(products);

            static void PrintAll(List<IPrintable> items)
            {
                foreach (var product in items)
                {
                    Console.WriteLine(product.ToText());
                }
            }
        }

    }
}







