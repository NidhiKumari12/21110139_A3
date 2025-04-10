using System;

namespace MyCSharpApp
{
    class Task2_LoopsFunctions
    {
        public static void Run()
        {
            Console.WriteLine("Numbers from 1 to 10:");
            for (int i = 1; i <= 10; i++)
                Console.Write(i + " ");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Enter a number for factorial calculation (or type 'exit' to quit): ");
                string input = Console.ReadLine()?.Trim() ?? "";

                if (input.ToLower() == "exit") 
                    break;

                if (int.TryParse(input, out int num) && num >= 0)
                {
                    Console.WriteLine($"Factorial of {num} is {Factorial(num)}");
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a non-negative integer.");
                }
            }
        }

        static long Factorial(int n) => (n <= 1) ? 1 : n * Factorial(n - 1);
    }
}
