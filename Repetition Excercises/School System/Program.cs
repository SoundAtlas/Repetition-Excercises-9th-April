using Repetition_Excercises.School_System;

namespace Repetition_Excercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new School("Tech College");
            bool running = true;
            Console.WriteLine($"=== {school.Name} Administration ===\n");
            while (running)
            {
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Add teacher");
                Console.WriteLine("3. Show all people");
                Console.WriteLine("4. Search for person");
                Console.WriteLine("5. Show team");
                Console.WriteLine("6. Add grade to student");
                Console.WriteLine("7. Exit");
                Console.Write("\nChoice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        {
                            string name = ReadText("Enter student name: ");
                            int age = ReadNumber("Enter student age: ");
                            string team = ReadText("Enter student team: ");
                            Student student = new Student(name, age, team);
                            school.AddPerson(student);
                            Console.WriteLine("Student added successfully!\n");
                            break;
                        }
                    case "2":
                        {
                            string name = ReadText("Enter teacher name: ");
                            int age = ReadNumber("Enter teacher age: ");
                            string subject = ReadText("Enter teacher subject: ");
                            Teacher teacher = new Teacher(name, age, subject);
                            school.AddPerson(teacher);
                            Console.WriteLine("Teacher added successfully!\n");
                            break;
                        }
                    case "3":
                        {
                            school.ShowAll();
                            break;
                        }
                    case "4":
                        {
                            string name = ReadText("Enter name to search: ");
                            Person? person = school.FindPerson(name);
                            if (person != null)
                            {
                                Console.WriteLine($"Found: {person.Name}, Age: {person.Age}, Role: {person.GetRole()}");
                            }
                            else
                            {
                                Console.WriteLine("Person not found.");
                            }
                            break;
                        }
                    case "5":
                        {
                            string teamName = ReadText("Enter team name: ");
                            school.ShowTeam(teamName);
                            break;
                        }
                    case "6":
                        {
                            string name = ReadText("Enter student name: ");
                            Person? person = school.FindPerson(name);
                            if (person is Student student)
                            {
                                int grade = ReadNumber("Enter grade to add: ");
                                student.AddGrade(grade);
                                Console.WriteLine("Grade added successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Student not found.");
                            }
                            break;
                        }
                    case "7":
                        {
                            running = false;
                            break;
                        }
                }
            }
            Console.WriteLine("Goodbye!");
        }

        static string ReadText(string prompt)
        {
            Console.WriteLine(prompt);
            Console.Write(">");

            if (string.IsNullOrWhiteSpace(Console.ReadLine()))
            {
                Console.WriteLine("Input cannot be empty. Please try again.");
                return ReadText(prompt); // Recursive call until valid input is provided
            }

            return Console.ReadLine() ?? string.Empty;
        }

        static int ReadNumber(string prompt)
        {

            Console.WriteLine(prompt);
            Console.Write(">");

            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return ReadNumber(prompt); // Recursive call until valid input is provided
            }

            return number;
            // TODO: Vis prompt, laes input, konverter med int.Parse 
            // Valider at input er et gyldigt tal
        }
    }
}







