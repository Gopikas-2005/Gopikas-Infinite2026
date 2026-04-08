using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment2
{
    class Exception
    {
        public void NumberException(int num)
        {
            if (num < 0)
            {
                throw new ApplicationException("Number must be Greater than 0");
            }
            else
            {
                Console.WriteLine("The Number You Entered:" + num);
            }

        }
            
        
    
    public static void Main()
        {
            Exception e = new Exception();

            try
            {
                Console.WriteLine("Enter the Number");
                int num = Convert.ToInt32(Console.ReadLine());
                e.NumberException(num);

            }
            catch (ApplicationException mx)
            {
                Console.WriteLine("Negative Number Exception:" + mx.Message);
            }
        }
    }
}
