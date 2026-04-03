using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass4
{
    internal class Exchange

    {
        public string s;
        public string FirstIndex;
        public string LastIndex;
        public static void CharacterExchange()
        {
            Console.WriteLine("Enter the Name");
            string s = Console.ReadLine();
            if (s.Length > 1)
            {
                char First = s[0];
                char Last = s[s.Length - 1];
                Console.WriteLine(Last + s.Substring(1, s.Length - 2) + First);
            }
        }
        static void Main()
        {
            CharacterExchange();
        }
    }
}
