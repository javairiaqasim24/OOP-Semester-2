using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lilly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Liily's Age : ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Toy Price : ");
            int toy = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Price of Washing Machine : ");
            int washing = int.Parse(Console.ReadLine());
            Usd(age, toy, washing);

        }
        static void Usd(int age, int toy, int washing)
        {
            int sum = 0;
            int even = age / 2;
            int odd=age-even;
            for (int i = 1; i <= even; i++)
            {
                sum = sum + (10 * i);
            }
            int toyPrice = odd * toy;
            int Price = sum + toyPrice;
            int totalPrice = Price - even;

            if (totalPrice > washing)
            {
                Console.WriteLine($"You can buy washing machine and you have saved {totalPrice-washing} dollar");
               

            }
            else
            {
                Console.WriteLine("Insufficient money. you have just {totalPrice} dollar");
                
            }
        }
    }
}

