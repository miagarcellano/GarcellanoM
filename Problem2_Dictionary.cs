using System;
using System.Collections.Generic;

{
    struct Student
    {
        public string StudentNumber;
        public string Name;
        public string Program;
        public int YearLevel;
    }

    class Problem2_Dictionary
    {
        static Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>();

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                                Console.WriteLine("   STUDENT LOOKUP USING DICTIONARY ");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Search Student");
                Console.WriteLine("3. Display All Students");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter number: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid choice. Try again.\n");
                    continue;
                }

                switch (number)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        SearchStudent();
                        break;
                    case 3:
                        DisplayAllStudents();
                        break;
                    case 4:
                        Console.WriteLine("\nProgram exited.");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.\n");
                        break;
                }
            }
        }

        static void AddStudent()
        {
            Console.Write("\nEnter Student Number: ");
            string num = Console.ReadLine();

            if (studentDictionary.ContainsKey(num))
            {
                Console.WriteLine("Error: Duplicate Student Number. Student already exists!\n");
                return;
            }

            Student s;
            s.StudentNumber = num;
            Console.Write("Enter Name: ");
            s.Name = Console.ReadLine();
            Console.Write("Enter Program: ");
            s.Program = Console.ReadLine();
            Console.Write("Enter Year Level: ");
            int.TryParse(Console.ReadLine(), out s.YearLevel);

            studentDictionary.Add(num, s);
            Console.WriteLine("\nStudent added successfully!\n");
        }

        static void SearchStudent()
        {
            Console.Write("\nEnter Student Number to search: ");
            string num = Console.ReadLine();

            if (studentDictionary.TryGetValue(num, out Student s))
            {
                Console.WriteLine("\nStudent Found!");
                Console.WriteLine($"Student Number: {s.StudentNumber}");
                Console.WriteLine($"Name: {s.Name}");
                Console.WriteLine($"Program: {s.Program}");
                Console.WriteLine($"Year Level: {s.YearLevel}\n");
            }
            else
            {
                Console.WriteLine("Student does not exist.\n");
            }
        }

        static void DisplayAllStudents()
        {
            if (studentDictionary.Count == 0)
            {
                Console.WriteLine("\nNo student records found.\n");
                return;
            }

                        Console.WriteLine("          STUDENT RECORDS          ");
            foreach (var kvp in studentDictionary)
            {
                Student s = kvp.Value;
                Console.WriteLine($"Student Number: {s.StudentNumber}");
                Console.WriteLine($"Name: {s.Name}");
                Console.WriteLine($"Program: {s.Program}");
                Console.WriteLine($"Year Level: {s.YearLevel}\n");
            }
        }
    }
} 
