using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Ass2
{
    internal class Rows
    {
        public static void Row()
        {
            Console.WriteLine("==============================#1 To Display the Rows======================");
            Console.WriteLine("Enter the number");
            string nums = Console.ReadLine();
            for (int i = 0; i < 4; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}{0}{0}{0}",nums);
                }
                else
                {
                    Console.WriteLine("{0} {0} {0} {0}",nums);
                }
            }
        }
        public static void Days()
        {
            Console.WriteLine("========================#2 Days=======================");
            Console.WriteLine("Enter the number of days from 1 to 7:");
            string days = Console.ReadLine();
            switch (days)
            {
                case "1":
                    Console.WriteLine("Sunday");
                    break;
                case "2":
                    Console.WriteLine("Monday");
                    break;
                case "3":
                    Console.WriteLine("Tuesday");
                    break;
                case "4":
                    Console.WriteLine("Wednesday");
                    break;
                case "5":
                    Console.WriteLine("Thursday");
                    break;
                case "6":
                    Console.WriteLine("Friday");
                    break;
                case "7":
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid Input!..... Please Enter the number between 1 to 7");
                    break;

            }
        }
    }
}
