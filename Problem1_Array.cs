using System;

    struct Student
    {
        public string StudentNumber;
        public string Name;
        public string Program;
        public int YearLevel;
    }

    class Problem1_Array
    {
        static Student[] students = new Student[10];
        static int studentCount = 0;

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("     STUDENT RECORD MANAGEMENT     ");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display All Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Update Student");
                Console.WriteLine("5. Delete Student");
                Console.WriteLine("6. Exit");
                Console.Write("\nEnter number: ");

                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Invalid number. Try again.\n");
                    continue;
                }

                switch (number)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        DisplayAllStudents();
                        break;
                    case 3:
                        SearchStudent();
                        break;
                    case 4:
                        UpdateStudent();
                        break;
                    case 5:
                        DeleteStudent();
                        break;
                    case 6:
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
            if (studentCount >= 10)
            {
                Console.WriteLine("Cannot add more students. Maximum limit (10) reached.");
                return;
            }

            Student s;
            Console.Write("\nEnter Student Number: ");
            s.StudentNumber = Console.ReadLine();
            Console.Write("Enter Name: ");
            s.Name = Console.ReadLine();
            Console.Write("Enter Program: ");
            s.Program = Console.ReadLine();
            Console.Write("Enter Year Level: ");
            int.TryParse(Console.ReadLine(), out s.YearLevel);
            students[studentCount] = s;
            studentCount++;
            Console.WriteLine("\nStudent added successfully!\n");
        }

        static void DisplayAllStudents()
        {
            if (studentCount == 0)
            {
                Console.WriteLine("\nNo student records found.\n");
                return;
            }

            Console.WriteLine("          STUDENT RECORDS          ");
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"Student Number: {students[i].StudentNumber}");
                Console.WriteLine($"Name: {students[i].Name}");
                Console.WriteLine($"Program: {students[i].Program}");
                Console.WriteLine($"Year Level: {students[i].YearLevel}\n");
            }
        }

        static void SearchStudent()
        {
            Console.Write("\nEnter Student Number to search: ");
            string num = Console.ReadLine();

            for (int i = 0; i < studentCount; i++)
            {
                if (students[i].StudentNumber == num)
                {
                    Console.WriteLine("\nStudent Found!");
                    Console.WriteLine($"Student Number: {students[i].StudentNumber}");
                    Console.WriteLine($"Name: {students[i].Name}");
                    Console.WriteLine($"Program: {students[i].Program}");
                    Console.WriteLine($"Year Level: {students[i].YearLevel}\n");
                    return;
                }
            }
            Console.WriteLine("Student not found.\n");
        }

        static void UpdateStudent()
        {
            Console.Write("\nEnter Student Number to update: ");
            string num = Console.ReadLine();

            for (int i = 0; i < studentCount; i++)
            {
                if (students[i].StudentNumber == num)
                {
                    Console.Write("Enter New Name: ");
                    students[i].Name = Console.ReadLine();
                    Console.Write("Enter New Program: ");
                    students[i].Program = Console.ReadLine();
                    Console.Write("Enter New Year Level: ");
                    int.TryParse(Console.ReadLine(), out students[i].YearLevel);

                    Console.WriteLine("Student record updated successfully!\n");
                    return;
                }
            }
            Console.WriteLine("Student not found.\n");
        }

        static void DeleteStudent()
        {
            Console.Write("\nEnter Student Number to delete: ");
            string num = Console.ReadLine();

            for (int i = 0; i < studentCount; i++)
            {
                if (students[i].StudentNumber == num)
                {
                    for (int j = i; j < studentCount - 1; j++)
                    {
                        students[j] = students[j + 1];
                    }
                    studentCount--;
                    Console.WriteLine("Student record deleted successfully!\n");
                    return;
                    
                }
            }
            Console.WriteLine("Student not found.\n");
        }
    }
