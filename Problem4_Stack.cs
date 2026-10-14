using System;
using System.Collections.Generic;

{
    struct Operation
    {
        public string Action;
        public string StudentNumber;
        public string StudentName;
    }

    class Problem4_Stack
    {
        static Stack<Operation> operationHistory = new Stack<Operation>();

        static void Main(string[] args)
        {
            // Populate sample operations to match standard workflow demo if needed
            // operationHistory.Push(new Operation { Action = "Added Juan" });
            // operationHistory.Push(new Operation { Action = "Added Maria" });
            // operationHistory.Push(new Operation { Action = "Updated Juan" });
            // operationHistory.Push(new Operation { Action = "Deleted Pedro" });

            bool running = true;
            while (running)
            {
                
                Console.WriteLine("         OPERATION HISTORY         ");
                
                Console.WriteLine("1. View Operation History");
                Console.WriteLine("2. View Last Operation");
                Console.WriteLine("3. Remove Last Operation");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid choice. Try again.\n");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        ViewOperationHistory();
                        break;
                    case 2:
                        ViewLastOperation();
                        break;
                    case 3:
                        RemoveLastOperation();
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

        static void ViewOperationHistory()
        {
            if (operationHistory.Count == 0)
            {
                Console.WriteLine("\nNo recorded operations.\n");
                return;
            }

            Console.WriteLine("\nOPERATION HISTORY");
            int count = 1;
            foreach (var op in operationHistory)
            {
                string label = string.IsNullOrEmpty(op.Action) ? $"{op.StudentName}" : op.Action;
                Console.WriteLine($"{count}. {label}");
                count++;
            }
            Console.WriteLine();
        }

        static void ViewLastOperation()
        {
            if (operationHistory.Count == 0)
            {
                Console.WriteLine("\nNo recorded operations.\n");
                return;
            }

            Operation lastOp = operationHistory.Peek();
            string label = string.IsNullOrEmpty(lastOp.Action) ? $"{lastOp.StudentName}" : lastOp.Action;
            Console.WriteLine($"\nLast Operation: {label}\n");
        }

        static void RemoveLastOperation()
        {
            if (operationHistory.Count == 0)
            {
                Console.WriteLine("\nNo recorded operations to remove.\n");
                return;
            }

            operationHistory.Pop();
            Console.WriteLine("\nLast operation removed successfully!\n");
        }
    }
}
