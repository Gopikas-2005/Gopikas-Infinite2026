using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigments1
{
     class Triplets
    {
        public static int Tripletssum(int s1,int s2)
        {
            if (s1 == s2)
            {
                return 3 * (s1 + s2);
            }
            else
            {
                return s1 + s2;
            }
        }
    }
}
