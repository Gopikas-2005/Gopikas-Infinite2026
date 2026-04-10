using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Program
    {
        public static void Squares()
        {
            Console.WriteLine("Enter the Number of times You want to Insert in the list");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> arr = new List<int>();
            for(int i = 0; i < n; i++)
            {
                int num= Convert.ToInt32(Console.ReadLine());
                arr.Add(num);
            }
            var Operation = from i in arr
                            where i*i > 20
                            select i;
            foreach(int i in Operation)
            {
                Console.WriteLine(i+"->"+i*i);
            }
            
        }
        static void Main(string[] args)
        {
            Squares();
        }
    }
}
