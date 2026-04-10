using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class StringOps
    {
        public static void stringops()
        {
            List<String> strings = new List<String>()
            {
                "mum",
                "amsterdam",
                "bloom"
            };
            var Operations = from i in strings
                             where i.StartsWith("a") && i.EndsWith("m")
                             select i;
            foreach(var i in Operations)
            {
                Console.WriteLine(i);
            }
            
        }
        static void Main()
        {
            stringops();
        }
    }
}
