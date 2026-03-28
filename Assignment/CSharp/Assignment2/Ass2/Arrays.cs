using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass2
{
    internal class Arrays
    {
        public static void Arrayops()
        {
            Console.WriteLine("======================#1 To display the Array Elements Total============================");
            int[] arr = new int[5] { 10, 20, 30, 40, 50 };
            int total = 0;
            foreach (int i in arr)
            { 
                total += i;
            }
            Console.WriteLine("The Average of an Array Elements:" + total / 5.0);
        }
        public static void Arraysmaxmin()
        {
            Console.WriteLine("===================== The MaxMin of an Array Elements===================");
            int[] arr = new int[5] { 4, 2, 6, 8, 10 };
            
            int max = arr[0];
            int min = arr[0];
            for (int i=0 ; i <arr.Length;i++ )
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("The Maximum Element in an Array:"+max);
            Console.WriteLine("Te Minimum Element in an Arry:"+min);
            

        }       
        public static void Marks()
        {
            int[] arr = new int[10];
            int TotalMarks = 0;
            int max = 0;
            int min = 0;
            Console.WriteLine("====================#2 Marks of 10 Students===================");
            for (int i = 0; i < 10; i++)
            {
                
                Console.WriteLine($"Enter the Students Marks {i + 1}:");
                arr[i] = int.Parse(Console.ReadLine());
                TotalMarks += arr[i];
                if (i == 0)
                {
                     max = arr[i];
                     min = arr[i];
                }
                if ( arr[i] > max )
                {
                    max = arr[i]; 
                }
                if (arr[i] < min )
                {
                    min = arr[i];
                }
                
             }
                
            Console.WriteLine("Total:" + TotalMarks);
            Console.WriteLine("Average:" + TotalMarks / 10.0);
            Console.WriteLine("MaximumMarks:" + max);
            Console.WriteLine("MinimumMarks:" + min);
            Array.Sort(arr);
            Console.WriteLine("Marks in Ascending Order:" + string.Join(",", arr));
            Array.Reverse(arr);
            Console.WriteLine("Marks in Descending Order:"+string.Join(",",arr));
        }
        public static void ArrayCopy()
        {
            Console.WriteLine("===================#3 The Copy of an Array==================");
            int [] arr = new int[5] { 10, 20, 30, 40, 50 };
            int[] arr2 = new int[5];
            for (int i=0; i<arr.Length;i++)
            {
                arr2[i] = arr[i];
            }
            Console.WriteLine("The Original Elements of an Array is:", arr);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("The Copy Elements of an Array is:", arr2);
            foreach (int i in arr2)
            {
                Console.WriteLine(i);
            }

        }
        
    }
}
