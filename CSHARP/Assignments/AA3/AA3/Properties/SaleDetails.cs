using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA3.Properties
{
    class SaleDetails
    {
        public int SalesNo;
        public int ProductNo;
        public decimal Price;
        public DateTime DateOfSale;
        public int Qty;
        public decimal TotalAmount;

        public SaleDetails(int salesNo, int productNo, decimal price, DateTime dateOfSale, int qty)
        {
            SalesNo = salesNo;
            ProductNo = productNo;
            Price = price;
            DateOfSale = dateOfSale;
            Qty = qty;
            Sales();
        }

        private void Sales()
        {
            TotalAmount = Price * Qty;
        }

        public void ShowData()
        {
            Console.WriteLine($"Sales Number: {SalesNo}");
            Console.WriteLine($"Product Number: {ProductNo}");
            Console.WriteLine($"Price per unit: {Price:C}");
            Console.WriteLine($"Date of Sale: {DateOfSale.ToShortDateString()}");
            Console.WriteLine($"Quantity sold: {Qty}");
            Console.WriteLine($"Total Amount: {TotalAmount:C}");
        }
        public static void Main()
        {
            SaleDetails sd1 = new SaleDetails(10, 1000, 25.5m, DateTime.Today, 9);

            SaleDetails sd2 = new SaleDetails(20, 1500, 45m, DateTime.Today, 8);
            Console.WriteLine("-------------TODAY SALE DETAILS------");
            sd1.ShowData();

            Console.WriteLine("-----------------------------------");
            sd2.ShowData();


            Console.Read();
        }
    }
}
    
