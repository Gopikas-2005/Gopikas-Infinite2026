using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigments1
{
     class Multiplication
    {
        public static void MultiplicationTable()
            {
        int n = int.Parse(Console.ReadLine());
        int i = 0;
            while (i <= 10)
            {
                int results = n * i;
                Console.WriteLine($" {n} * {i} = {results} ");
                i++;
            }
            
            }
    }
}
