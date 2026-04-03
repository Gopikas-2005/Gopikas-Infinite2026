using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass4
{
    internal class Program
    {
        public string s;
        public static void RemovePosition()
        {
            Console.WriteLine("Enter the Name:");
            string s = Console.ReadLine();
            Console.WriteLine("Enter the Position to be Removed");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && x < s.Length)
            {
                s = s.Remove(x, 1);
                Console.WriteLine(s);
            }


        }
        static void Main()
        {
            RemovePosition();
        }
    }
}
