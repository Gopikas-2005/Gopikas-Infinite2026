using System;

namespace DelegateCalculator
{
    delegate int CalculatorDelegate(int a, int b);

    class PerformOperation
    {
       public   int Add(int a, int b) => a + b;
        public  int Subtract(int a, int b) => a - b;
        public  int Multiply(int a, int b) => a * b;

      
        

        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            PerformOperation op1 = new PerformOperation();
            op1.Add(num1,num2);
            op1.Subtract(num1, num2);
            op1.Multiply(num1, num2);
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}