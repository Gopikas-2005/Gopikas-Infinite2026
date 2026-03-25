using System;


namespace Assignments1
{
    class PositiveNegative
    {
        public static void PosNeg(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"{n} is a Positive Number");
            }
            else if (n == 0)
            {
                Console.WriteLine($"{n} is Zero");
            }
            else
            {
                Console.WriteLine($"{n} is a Negative Number");
            }
        }
    }
}
