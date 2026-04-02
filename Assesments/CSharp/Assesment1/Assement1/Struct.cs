using System;

namespace Assesment1
{
    class Structures
    {
        struct Employee
        {
            public string Name;
            public DateOfBirth DOB; 
            public struct DateOfBirth
            {
                public int Day;
                public int Month;
                public int Year;
            }
        }

        static void Main(string[] args)
        {
            Employee[] employees = new Employee[2];

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Enter name of employee {i + 1}:");
                employees[i].Name = Console.ReadLine();

                Console.WriteLine("Enter day of birth :");
                employees[i].DOB.Day = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter month of birth :");
                employees[i].DOB.Month = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter year of birth:");
                employees[i].DOB.Year = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Employee Details:");
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Name: {employees[i].Name}");
                Console.WriteLine($"Date of Birth: {employees[i].DOB.Day:D2}-{employees[i].DOB.Month:D2}-{employees[i].DOB.Year:D2}");
            }

            Console.ReadLine();
        }
    }
}
