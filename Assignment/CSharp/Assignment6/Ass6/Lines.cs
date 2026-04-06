using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http.Headers;

namespace Ass6
{
    class Counts
    {

        public static void ReadLines()
        {
            int lineCounts = 0;

            using(StreamReader sr= new StreamReader("Array.txt"))
            {

                while (sr.ReadLine() != null)
                {
                    lineCounts++;
                }
                Console.WriteLine("The Number of Lines in a File:"+lineCounts);
            }
        }
        static void Main()
        {
            Counts.ReadLines();
        }
    }
   
}
