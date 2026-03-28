using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass2
{
    internal class Strings
    {
        public static void Stringlength()
        {
            Console.WriteLine("===================== #1 To Check String Length====================");
            Console.WriteLine("Enter the word to Check Length:");
            string str = Console.ReadLine();
            Console.WriteLine("The Length of the String is:" + str.Length);
        }
        public static void StrRev() 
        {
            Console.WriteLine("==========================#2 To check String Reverse=================");
            Console.WriteLine("Enter the Word to Reverse:");
            string rev_string = " ";
            string str = Console.ReadLine();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev_string += str[i];
            }
            Console.WriteLine("The Reverse of the Word is:"+rev_string);
            
        }
        public static void StrEqual()
        {
            Console.WriteLine("==========================#3 To Check The Strings are Equal=========================");
            Console.WriteLine("Enter The Word1:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the Word2:");
            string str2 = Console.ReadLine();
            if (str1 == str2)
            {
                Console.WriteLine("The Two Strings are Equal");
            }
            else if (str1.Length != str2.Length)
            {
                Console.WriteLine("The Two Strings are not Equal");
            }
            else
            {
                Console.WriteLine("The Two Strings are not Equal");
            }
        }
    }
}
