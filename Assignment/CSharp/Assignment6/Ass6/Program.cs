using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Ass6
{
    class ReadWrite
    {
        public static FileStream fs;
        public static void WriteStreams()
        {
                using (fs = new FileStream("Array.txt", FileMode.Create, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    string[] str = { "Books", "Authors", "Exams", "Pen", "Paper" };
                    foreach (var i in str)
                    {
                        sw.WriteLine(i);
                    }
                }
            
        }
        public static void ReadStreams()
        {
            fs = new FileStream("Array.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string str= sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str= sr.ReadLine();
                
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            ReadWrite.WriteStreams();
            ReadWrite.ReadStreams();
            Console.WriteLine("Program Started");
            Console.WriteLine("File path: " + Path.GetFullPath("Array.txt"));
        }
    }
}
