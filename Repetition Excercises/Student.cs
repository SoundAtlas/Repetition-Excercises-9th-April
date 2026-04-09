namespace Repetition_Excercises
{

    public class Student
    {

        public string Name { get; set; }
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
            }
        }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Introduce()
        {
            Console.WriteLine($"My name is {Name} and I am {Age} years old");
        }


    }
}
