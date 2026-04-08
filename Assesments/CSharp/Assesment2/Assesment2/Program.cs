using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment2
{
    abstract class Student
    {
        public string Name = "GopikaS";
        public int StudentId = 123;
        public int Grade { get; set; }

        public abstract  Boolean Ispassed(int Grade);
       
    }
    class Undergraduate : Student
    {
        public override bool Ispassed(int Grade)
        {
            return Grade > 70.0;
        }
    }
    class Graduate : Student
    {
        public override bool Ispassed(int Grade)
        {
            return Grade > 80.0;
        }
    
        
        static void Main(string[] args)
        {
            Student ug = new Undergraduate();
            Student g = new Graduate();
            Console.WriteLine("Enter the Grade");
            int Grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Undergraduate Passed:"+ug.Ispassed(Grade));
            Console.WriteLine("Graduate Passed:"+g.Ispassed(Grade));            
            
        }

    }
}
