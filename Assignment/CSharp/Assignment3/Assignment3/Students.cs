using Ass3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3
{
    class Students
    {
        public class StudentsDetails
        {
            string Rollno, Name, Classes, Semester, Branch;


            public StudentsDetails(string rollno, string name, string classes, string semester, string branch)
            {
                Rollno = rollno;
                Name = name;
                Classes = classes;
                Semester = semester;
                Branch = branch;
            }
            public void showStudentDetails()
            {
                Console.WriteLine("RollNo: " + Rollno);
                Console.WriteLine("Enter th StudentName: " + Name);
                Console.WriteLine("Enter th Class: " + Classes);
                Console.WriteLine("Enter the Semester: " + Semester);
                Console.WriteLine("Enter the Branch: " + Branch);
            }

        }

        class Marks : StudentsDetails
        {
            int[] marks = new int[5];
            public Marks(string rollno, string name, string classes, string Semester, string branch) : base(rollno, name, classes, Semester, branch)
            {
            }

            public void GetMarks()
            {
                Console.WriteLine("Enter marks for 5 subjects:");
                for (int i = 0; i < marks.Length; i++)
                {
                    Console.Write("Subject " + (i + 1) + ": ");
                    try
                    {
                        marks[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Enter a valid Number");
                        i--;
                    }
                }
            }
            public void DisplayResult()
            {
                int totalMarks = 0;
                bool isFailed = false;
                foreach (int mark in marks)
                {
                    if (mark < 35)
                    {
                        isFailed = true;
                        break;
                    }
                    totalMarks += mark;
                }
                double averageMarks = totalMarks / (double)marks.Length;
                if (isFailed || averageMarks < 50)
                {
                    Console.WriteLine("Result: Failed");
                }
                else
                {
                    Console.WriteLine("Result: Passed");
                }
            }

            static void Main(string[] args)
            {

                Marks student = new Marks("123", "GopikaS", "CSE-A", "1", "CSE");
                student.showStudentDetails();
                student.GetMarks();
                student.DisplayResult();


            }
        }
    }
}
