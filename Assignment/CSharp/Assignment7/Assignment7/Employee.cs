using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{

    public  class Emp
    {
        
            public int EmpId { get; set; }
            public string EmpName { get; set; }
            public string EmpCity { get; set; }
            public double EmpSalary { get; set; }

        
        public static void EmployeesOps()
        {
            List<Emp> EmployeesTasks = new List<Emp>();
            for (int i = 0; i < 5; i++)
            {
                Emp employee = new Emp();
                Console.WriteLine("Enter the EmpId:");
                employee.EmpId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the EmpName:");
                employee.EmpName= Console.ReadLine();

                Console.WriteLine("Enter the EmpIdCity:");
                employee.EmpCity = Console.ReadLine();

                Console.WriteLine("Enter the EmpIdSalary:");
                employee.EmpSalary = Convert.ToInt32(Console.ReadLine());

                EmployeesTasks.Add(employee);

            }
            foreach(var i in EmployeesTasks)
            {
              
                Console.WriteLine("The Employees in the List are:"+i.EmpId+" "+i.EmpName+" "+i.EmpCity+" "+i.EmpSalary);
                
            }

            var EmployeeSalary = from emp in EmployeesTasks
                                 where emp.EmpSalary > 25000
                                 select emp;
            Console.WriteLine("The Employee Salary Grater than 25000 are:" );

            foreach (var emp in EmployeeSalary)
            {
                Console.WriteLine(emp.EmpName);
            }
            var Regions = from emp in EmployeesTasks
                          where emp.EmpCity == "Bangalore"
                          select emp;
            Console.WriteLine("The Employees Residing in the Bangalore regions are:" );

            foreach (var emp in Regions)
            {
                Console.WriteLine(emp.EmpName);
            }
            var ascending=from emp in EmployeesTasks
                          orderby  emp.EmpName ascending
                          select emp;
            Console.WriteLine("The Employees name in the Ascending Order:" );

            foreach (var emp in ascending)
            {
                Console.WriteLine(emp.EmpName);

            }



        } 
        static void Main()
        {
            Emp.EmployeesOps();
        }
    }
}
