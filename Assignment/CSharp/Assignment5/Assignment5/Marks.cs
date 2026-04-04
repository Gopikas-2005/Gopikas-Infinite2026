using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class ScholarshipAmountException : ApplicationException
    {
        public ScholarshipAmountException(string msg) : base(msg) { }

    }
    internal class Scholarship
    {


        public   int Merit(int Marks, int fees)
        {

            if (Marks >= 70 && Marks <= 80)
            {
                int ScholarshipAmount = (int)(fees * 20.0 /100.0);
                return ScholarshipAmount;

            }
            else if (Marks > 80 && Marks <= 90)
            {
                int ScholarshipAmount = (int)(fees * 30.0 / 100.0);
                return ScholarshipAmount;

            }
            else if (Marks > 90)
            {
                int ScholarshipAmount = (int)(fees * 50.0 / 100.0);
                return ScholarshipAmount;

            }
            else
            {
                throw new ScholarshipAmountException("No Scholarship Amount Can be Provided");
            }


        }
        public static void Main()
        {
                
            try
            {
                Console.WriteLine("Enter the Marks");
                int Marks = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Fees");
                int fees = Convert.ToInt32(Console.ReadLine());
                Scholarship amount = new Scholarship();
                int scholarshipAmount = amount.Merit( Marks,  fees);
                Console.WriteLine("ScholarshipAmounts"+scholarshipAmount);

            }
            catch(ScholarshipAmountException e)
            {
                Console.WriteLine("Error:"+e.Message);
            }
            catch(Exception)
            {
                Console.WriteLine("Enter a valid Number");
            }

        }

    }
}


