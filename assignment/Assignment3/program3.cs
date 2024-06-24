using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    public class Saledetails
    {
        private int SalesNo;
        private int ProductNo;
        private double Price;
        private DateTime DateOfSale;
        private int Qty;
        private double TotalAmount;
        public Saledetails(int salesNo, int productNo, double price, int qty, DateTime dateOfSale)
        {
            SalesNo = salesNo;
            ProductNo = productNo;
            Price = price;
            Qty = qty;
            DateOfSale = dateOfSale;
            Sales();
        }
        public void Sales()
        {
            TotalAmount = Qty * Price;
        }
        public void ShowData()
        {
            Console.WriteLine($"Sales Number: {SalesNo}");
            Console.WriteLine($"Product Number: {ProductNo}");
            Console.WriteLine($"Price per unit: {Price:C}");
            Console.WriteLine($"Quantity: {Qty}");
            Console.WriteLine($"Date of Sale: {DateOfSale.ToShortDateString()}");
            Console.WriteLine($"Total Amount: {TotalAmount:C}");
        }
    }
    class MainProgram
    {
        static void Main()
        {
            Saledetails sale1 = new Saledetails(234, 1221, 500, 10, DateTime.Now);
            sale1.ShowData();
        }
    }
}
