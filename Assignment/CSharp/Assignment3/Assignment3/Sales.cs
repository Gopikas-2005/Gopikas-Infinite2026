using System;


namespace Ass3
{
    public class SalesDetails
    {
        string SalesNo, ProductNo, DateOfSale;
        int Price, Qty, TotalAmount;
        public SalesDetails(string salesNo, string productNo, int price, int qty, string dateOfSale)
        {
            SalesNo = salesNo;
            ProductNo = productNo;
            Price = price;
            Qty = qty;
            DateOfSale = dateOfSale;

        }
        class Sales : SalesDetails
        {
            public Sales(string salesNo, string productNo, int price, int qty, string dateOfSale) : base(salesNo, productNo, price, qty, dateOfSale)
            {
            }
            public void SalesDetailsMethod()
            {
                TotalAmount = Qty * Price;
                Console.WriteLine("Sales No: " + SalesNo);
                Console.WriteLine("Product No: " + ProductNo);
                Console.WriteLine("Price: " + Price);
                Console.WriteLine("Quantity: " + Qty);
                Console.WriteLine("Date of Sale: " + DateOfSale);
                Console.WriteLine("Total Amount: " + TotalAmount);
            }
        }

        static void Main()
        {
            Sales sales = new Sales("S001", "P001", 100, 5, "2024-06-01");
            sales.SalesDetailsMethod();
        }

    }
}

