namespace Repetition_Excercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>();

            students.Add(new Student("Andreas", 27));
            students.Add(new Student("Anika", 25));
            students.Add(new Student("Jane", 22));

            foreach (Student s in students)
            {
                studentDictionary.Add(s.Name, s);
                s.Introduce();
            }

            //Student student1 = studentDictionary["Andreas"];
            //student1.Introduce();

            Student oldest = FindOldest(students);
            Console.WriteLine($"{oldest.Name} is the oldest student at {oldest.Age} years old");




            static Student FindOldest(List<Student> students)
            {
                // Returner den aeldste studerende fra listen // Din kode her }
                if (students.Count == 0)
                {
                    return null;
                }

                Student oldest = students[0];

                for (int i = 1; i < students.Count; i++)
                {
                    if (students[i].Age > oldest.Age)
                    {
                        oldest = students[i];
                    }
                }

                return oldest;
            }
        }

    }
}







