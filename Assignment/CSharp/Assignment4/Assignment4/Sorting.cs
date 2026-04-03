using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass4
{
    internal class Sorting
    {
        public int n;

        public static void SortingMethod()
        {
            Stack<int> s = new Stack<int>();

            Console.WriteLine("Enter the Number");
            for (int i = 0; i < 10; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                s.Push(n);
            }
            List<int> stacks = s.ToList();
            stacks.Sort();
            stacks.Reverse();
            Console.WriteLine("The Stacks after Sorting in Descending Orders " + string.Join(" ",stacks));


        }
        static void Main()
        {
            SortingMethod();
        }
    }
}
