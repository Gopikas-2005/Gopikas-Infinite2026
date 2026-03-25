using Assigments1;
using System;

namespace Assignments1
{
    internal class ArithmaticOperations
    {
        static void Main()
        {
            Console.WriteLine("----------#1Equal Values------------");
            Console.WriteLine("Input Number1:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Number2:");
            int number2 = int.Parse(Console.ReadLine());
            Equal.Equalmethod(number1, number2);

            Console.WriteLine("---------#2Positive or negative---------");
            Console.WriteLine("Enter a Number:");
            int n = int.Parse(Console.ReadLine());
            PositiveNegative.PosNeg(n);

            Console.WriteLine("---------#3Arithmetic Operations---------");
            Console.WriteLine("Input First number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Second number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Operation:");
            string ops = Console.ReadLine();
            int result = Addition(num1, num2, ops);
            Console.WriteLine("Expected Output:" + result);

            Console.WriteLine("---------------#4Multiplication Tables-------------");
            Console.WriteLine("Enter the Number:");
            Multiplication.MultiplicationTable();

            Console.WriteLine("-------------#5Triplets-----------------");
            Console.WriteLine("Enter the Number1");
            int s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number2");
            int s2 = int.Parse(Console.ReadLine());
            int sums = Triplets.Tripletssum(s1, s2);
            Console.WriteLine("The Expected Sum is:"+sums);
                
        }
        public static int Addition(int num1, int num2, string ops)
        {
            if (ops == "+")
            {
                return num1 + num2;
            }
            else if (ops == "-")
            {
                return num1 - num2;
            }
            else if (ops == "*")
            {
                return num1 * num2;
            }
            else if (ops == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot be divide by Zero");
                    return 0;
                }
                else
                {
                    return num1 / num2;
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
                return 0;

            }

        }

    }
}

