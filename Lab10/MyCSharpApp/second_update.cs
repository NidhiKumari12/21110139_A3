using System;

namespace MyCSharpApp
{
    class BasicOperations_update
    {
        public static void Run()
        {
            int num1, num2;

            // Handle invalid input for num1
            while (true)
            {
                Console.Write("Enter first number: ");
                string input1 = Console.ReadLine() ?? ""; // Prevents null warning
                if (int.TryParse(input1, out num1))
                    break;
                Console.WriteLine("Invalid input! Please enter an integer.");
            }

            // Handle invalid input for num2
            while (true)
            {
                Console.Write("Enter second number: ");
                string input2 = Console.ReadLine() ?? ""; // Prevents null warning
                if (int.TryParse(input2, out num2))
                    break;
                Console.WriteLine("Invalid input! Please enter an integer.");
            }

            int sum = num1 + num2;
            Console.WriteLine($"Addition: {num1} + {num2} = {sum}");
            Console.WriteLine($"Subtraction: {num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"Multiplication: {num1} * {num2} = {num1 * num2}");

            // Handle division safely
            if (num2 != 0)
            {
                double result = (double)num1 / num2;
                Console.WriteLine($"Division: {num1} / {num2} = {result}");
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }

            Console.WriteLine(sum % 2 == 0 ? "Sum is even." : "Sum is odd.");
        }
    }
}
