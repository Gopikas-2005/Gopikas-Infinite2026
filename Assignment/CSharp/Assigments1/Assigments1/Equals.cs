using System;


namespace Assignments1
{
    class Equal
    {
        public static void Equalmethod(int number1, int number2)
        {
            if (number1 == number2)
            {
                Console.WriteLine($"Expected Output:{number1} and {number2} are equal");
                
            }
            else
            {
                Console.WriteLine($"Expected Output:{number1} and {number2} are not equal");
                
            }
        }

    }
}
