using System;

namespace Assesment2
{
    class Products
    {
        public int ProductId;
        public string ProductName;
        public double ProductPrice;
    }

    class SortProducts
    {
        public static void SortedProducts()
        {
            Products[] arr = new Products[10];

           
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter details for Product {i + 1}");

                arr[i] = new Products();

                arr[i].ProductId = i + 1;

                Console.Write("Enter Product Name: ");
                arr[i].ProductName = Console.ReadLine();

                Console.Write("Enter Product Price: ");
                arr[i].ProductPrice = Convert.ToDouble(Console.ReadLine());
            }

            
            Array.Sort(arr, (a, b) => a.ProductPrice.CompareTo(b.ProductPrice));

            
            Console.WriteLine("\nSorted Products by Price:");
            foreach (var p in arr)
            {
                Console.WriteLine($"{p.ProductId} - {p.ProductName} - {p.ProductPrice}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SortProducts.SortedProducts();
        }
    }
}