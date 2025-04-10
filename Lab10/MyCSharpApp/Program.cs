using System;
using MyCSharpApp;  
using MyCSharpApp.updated;

namespace MyCSharpApp
{
    class MainProgram
    {
        static void Main()
        {
            Console.WriteLine("Select a Task to Run:");
            Console.WriteLine("1 - Basic Operations");
            Console.WriteLine("2 - Loops Functions");
            Console.WriteLine("3 - Object-Oriented Programming");
            Console.WriteLine("4 - BasicOperations_update");
            Console.WriteLine("5 - LoopsFunctions_update"); 
            Console.WriteLine("6 - StudentOOP_update");


            Console.Write("Enter choice: ");
            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    Task1_BasicOperations.Run();
                    break;
                case "2":
                    Task2_LoopsFunctions.Run();
                    break;
                case "3":
                    Task3_StudentOOP.Run();
                    break;
                case "4":
                    BasicOperations_update.Run();
                    break;
                case "5":
                    LoopsFunctions_update.Run();
                    break;
                case "6":
                    StudentOOP_update.Run();
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
