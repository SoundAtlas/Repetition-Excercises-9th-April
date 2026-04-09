namespace Repetition_Excercises
{
    public class Product : IPrintable, ISearchable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string ToText()
        {
            return $"Product: {Name}, Price: {Price:C}";
        }

        public bool Contains(string searchText)
        {
            return Name.Contains(searchText, StringComparison.OrdinalIgnoreCase);
        }
    }
}
