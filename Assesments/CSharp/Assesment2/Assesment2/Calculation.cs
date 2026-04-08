using System;

namespace DelegateCalculator
{
    delegate int CalculatorDelegate(int a, int b);

    class Program
    {
        static int Add(int a, int b) => a + b;
        static int Subtract(int a, int b) => a - b;
        static int Multiply(int a, int b) => a * b;

      
        static void PerformOperation(int x, int y, CalculatorDelegate operation, string operationName)
        {
            int result = operation(x, y);
            Console.WriteLine($"{operationName} of {x} and {y} = {result}");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            PerformOperation(num1, num2, Add, "Addition");
            PerformOperation(num1, num2, Subtract, "Subtraction");
            PerformOperation(num1, num2, Multiply, "Multiplication");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}