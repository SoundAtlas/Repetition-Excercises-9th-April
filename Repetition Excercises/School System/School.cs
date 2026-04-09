namespace Repetition_Excercises.School_System
{
    public class School
    {
        public string Name { get; set; }
        private List<Person> people;
        private Dictionary<string, List<Person>> teams;

        public School(string name)
        {
            Name = name;
            people = new List<Person>();
            teams = new Dictionary<string, List<Person>>();
        }

        public void AddPerson(Person person)
        {
            people.Add(person);
            if (person is Student student)
            {
                string teamName = student.TeamName;

                // Ensure the team exists in the dictionary
                if (!teams.ContainsKey(teamName))
                {
                    teams[teamName] = new List<Person>();
                }

                teams[teamName].Add(student);
            }
        }

        public void ShowAll()
        {
            foreach (Person p in people)
            {
                Console.WriteLine(p.ToText());
            }
        }

        public Person? FindPerson(string name)
        {
            foreach (Person p in people)
            {
                if (p.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return p;
                }
            }
            return null;

        }

        public void ShowTeam(string teamName)
        {
            if (teams.ContainsKey(teamName))
            {
                Console.WriteLine($"Team: {teamName}");
                foreach (Person p in teams[teamName])
                {
                    Console.WriteLine(p.ToText());
                }
            }
            else
            {
                Console.WriteLine($"Team '{teamName}' not found.");
            }
        }
    }
}
