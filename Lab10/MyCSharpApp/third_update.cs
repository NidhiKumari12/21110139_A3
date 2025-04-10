using System;

namespace MyCSharpApp
{
    class LoopsFunctions_update
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

                try
                {
                    if (int.TryParse(input, out int num) && num >= 0)
                    {
                        Console.WriteLine($"Factorial of {num} is {Factorial(num)}");
                    }
                    else
                    {
                        throw new FormatException("Invalid input! Please enter a non-negative integer.");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: The number is too large to calculate its factorial.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                }
            }
        }

        static long Factorial(int n)
        {
            try
            {
                return (n <= 1) ? 1 : checked(n * Factorial(n - 1)); // checked() ensures overflow is caught
            }
            catch (OverflowException)
            {
                throw new OverflowException("Factorial calculation resulted in an overflow.");
            }
        }
    }
}
