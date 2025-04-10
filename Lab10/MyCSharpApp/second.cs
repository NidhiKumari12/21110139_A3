using System;

namespace MyCSharpApp
{
    class Task1_BasicOperations
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");

            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine($"Addition: {num1} + {num2} = {sum}");
            Console.WriteLine($"Subtraction: {num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"Multiplication: {num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"Division: {num1} / {num2} = {(num2 != 0 ? (double)num1 / num2 : double.PositiveInfinity)}");

            if (sum % 2 == 0)
                Console.WriteLine("Sum is even.");
            else
                Console.WriteLine("Sum is odd.");
        }
    }
}
