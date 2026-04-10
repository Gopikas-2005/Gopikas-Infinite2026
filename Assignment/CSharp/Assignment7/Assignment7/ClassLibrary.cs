using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ClassLibrarayDll;

namespace Assignment7
{
    class Test
    {

        public static void Main()
        {
            FareProgram p = new FareProgram();
            Console.WriteLine("Enter the Name:");
            p.Name = Console.ReadLine();
            Console.WriteLine("Enter the Age:");
            p.Age = Convert.ToInt32(Console.ReadLine());
            p.CalculateConcession();
        }


    }
}
