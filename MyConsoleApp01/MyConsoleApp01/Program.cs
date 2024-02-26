using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> prodList = GetProductList();
            Console.WriteLine($"Code | Name       | Price");
            foreach (Product p in prodList)
            {
                Console.WriteLine($"{p.ProductCode} | {p.ProductName} | {p.Price}");
            }

            Console.ReadLine();
        }

        private static List<Product> GetProductList()
        {
            List<Product> productList = new List<Product>();
            productList.Add(new Product("A01", "Product A01", 2.99));
            productList.Add(new Product("A02", "Product A02", 3.99));
            productList.Add(new Product("B01", "Product B01", 12.99));
            productList.Add(new Product("B02", "Product B02", 22.99));
            productList.Add(new Product("B03", "Product B03", 44.99));
            productList.Add(new Product("C01", "Product C01", 55.66));

            return productList;
        }
    }

    public class Product
    {
        public Product(string code, string name, double price)
        {
            ProductCode = code;
            ProductName = name;
            Price = price;
        }

        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

    }
}
