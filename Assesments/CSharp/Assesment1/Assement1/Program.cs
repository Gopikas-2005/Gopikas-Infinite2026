using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssement1
{
     class Employee
    {
        public int Id;
        public string Name;
        public string Department;
        public double Salary;
        public Employee(int id, string name, string department, double salary)
        {
            Id = id;
            Name = name;
            Department = department;
            Salary = salary;
        }
        class EmployeeManagementMenu
        {
            static List<Employee> employees = new List<Employee>();

            public static void AddEmployee()
            {
                // Code to add employee
                Console.WriteLine("Enter the ID");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Department");
                string department = Console.ReadLine();
                Console.WriteLine("Enter the Salary");
                double salary= Convert.ToDouble(Console.ReadLine());
                employees.Add(new Employee(id, name, department, salary));
                Console.WriteLine("New Employee Added Successfully");



            }
            public static void ViewAllEmployees()
            {
                foreach (var employee in employees)
                {
                    Console.WriteLine("Employee Details:");
                    Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Department: {employee.Department}, Salary: {employee.Salary}");
                }
            }
            public static void SearchEmployeeByID()
            {
                Console.WriteLine("Enter the Employee Id to Search");
                int id = Convert.ToInt32(Console.ReadLine());
                foreach (var employee in employees)
                {
                    if (employee.Id == id)
                    {
                        Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Department: {employee.Department}, Salary: {employee.Salary}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Employee with the given Id are not found");
                    }
                }

            }
            public static void Update()
            {
                Console.WriteLine("Enter the Employee To get Updates of the Employee");
                int id = Convert.ToInt32(Console.ReadLine());
                foreach (var employee in employees)
                {
                    if (employee.Id == id)
                    {
                        Console.WriteLine("Enter the Name:");
                        employee.Name = Console.ReadLine();
                        Console.WriteLine("Enter the department");
                        employee.Department = Console.ReadLine();
                        Console.WriteLine("Enter the Salary");
                        employee.Salary = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("The Id of the Employees Details have been Updated Successfully");
                        Console.WriteLine("The Updated Details of the Id are:");
                        Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Department: {employee.Department}, Salary: {employee.Salary}");
                    }  
                   
                }

            }
            public static void Delete()
            {
                Console.WriteLine("Enter the Employee Id to Get Delete");
                int id= Convert.ToInt32(Console.ReadLine());
                foreach (var employee in employees)
                {
                    if (employee.Id == id)
                    {
                        employees.Remove(employee);
                        Console.WriteLine("Employee Deleted Successfully");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("The Employee with the Given Id is Not Found");
                    }
                }


            }
        }
        
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Employee Management Menu:");
                Console.WriteLine("1. Add New Employee");
                Console.WriteLine("2. View All Employees");
                Console.WriteLine("3. Search Employee by ID");
                Console.WriteLine("4. Update Employee Details");
                Console.WriteLine("5. Delete Employee");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {



                    case 1:
                    EmployeeManagementMenu.AddEmployee();
                        break;
                    case 2:

                    EmployeeManagementMenu.ViewAllEmployees();
                        break;
                    case 3:

                    EmployeeManagementMenu.SearchEmployeeByID();
                        break;
                    case 4:

                    EmployeeManagementMenu.Update();
                        break;
                    case 5:
                    EmployeeManagementMenu.Delete();
                        break;
                    case 6:
                        return;
                    default:
                    Console.WriteLine("Invalid choice. Please try again.");
                     break;
            }
            }
        }
    }
}

