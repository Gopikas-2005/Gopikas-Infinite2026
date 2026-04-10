using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarayDll
{
    public class FareProgram
    {

        public static int TotalFare { get; set; } = 1000;
        public string Name { get; set; }
        public int Age { get; set; }
        public int Fare { get; set; }
        public void CalculateConcession()
        {

            if (Age < 5)
            {
                Console.WriteLine("Littel Champs -Free Ticket");
            }
            else if (Age > 60)
            {
                var discountedFare = (TotalFare) * 30.0 / 100.0;
                Console.WriteLine("Senior Citizen - The Discounted Fare is:" + discountedFare);
            }
            else
            {
                Console.WriteLine("The total Fare is:" + TotalFare);
            }


        }

    }
}
