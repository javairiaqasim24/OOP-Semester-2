using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
          {
            Console.WriteLine("                  STORE");
            Console.WriteLine("1.Add Product");
            Console.WriteLine("2.View All Product.");
            Console.WriteLine("3.Find Product with the Highest Unit Price");
            Console.WriteLine("4.View Sales Tax of All Products.");
            Console.WriteLine("5.Products to be Ordered");
            Console.WriteLine("6.Exit");
            Console.WriteLine("Enter your choice   ");
            string choice = Console.ReadLine();
          
                if (choice == "1")
                {
                    Console.Write("Enter name of Product  ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Category of Product  ");
                    string category = Console.ReadLine();
                    Console.Write("Enter price of Product  ");
                    int price = int.Parse(Console.ReadLine());
                    Console.Write("Enter Stock Quantity  ");
                    int quantity = int.Parse(Console.ReadLine());
                    Console.Write("Enter Mininum Stock Quantity   ");
                    int sQuantity = int.Parse(Console.ReadLine());

                    Product product = new Product(name, category, price, quantity, sQuantity);
                    product.AddProduct();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("                         Products Are");
                    Product.ViewProducts();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Product With Highest Unit Price is ");
                    Product.HighPriceProduct();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Tax of Products are");
                    Product.ProductTax();
                }
                else if (choice == "5")
                {
                    Console.WriteLine("Product you have to ordered");
                    Product.Ordered();
                }
                else if (choice == "6")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                Console.ReadKey();
            }
        }
    }
}
