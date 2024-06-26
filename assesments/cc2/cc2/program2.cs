using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc2
{
    public class Products
    {
        public int Productid { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }
    public class program
    {
        static void Main(string[] args)
        {
            List<Products> productsList = new List<Products>();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Enter the Product details {i} :");
                Console.Write("Productid : ");
                int Productid = Convert.ToInt32(Console.ReadLine());
                Console.Write("ProductName : ");
                string ProductName = Console.ReadLine();
                Console.Write("Price : ");
                double Price = Convert.ToDouble(Console.ReadLine());
                Products product = new Products
                {
                    Productid = Productid,
                    ProductName = ProductName,
                    Price = Price
                };
                productsList.Add(product);
            }
            productsList.Sort((x, y) => x.Price.CompareTo(y.Price));
            Console.WriteLine("\n Sorted Products List Based on Price:");
            foreach (var product in productsList)
            {
                Console.WriteLine("Productid: {product.Productid}, Product Name: {product.productName}, Price: {product.Price}");
            }

        }
    }
}