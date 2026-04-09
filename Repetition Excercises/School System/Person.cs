namespace Repetition_Excercises.School_System
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract string GetRole();
        public string ToText()
        {
            return $"{GetRole()}: {Name} ({Age} years)";
        }
    }
}
