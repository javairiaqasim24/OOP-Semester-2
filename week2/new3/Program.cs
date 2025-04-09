using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM a1 = new ATM();
            a1.balance = 20000;
            while (true)
            {
                Console.WriteLine("Welcome to Banking Management Sysment");
                Console.WriteLine("Enter option....");
                Console.WriteLine("1.Check Balance");
                Console.WriteLine("2.Deposit Amount");
                Console.WriteLine("3.Withdraw Amount");
                Console.WriteLine("4.check history");
                int opt = int.Parse(Console.ReadLine());
                if (opt == 1)
                {
                    a1.check();
                }
                else if (opt == 2)
                {
                    a1.deposit();
                }
                else if (opt == 3)
                {

                    a1.withdraw();

                }
                else if (opt == 4)
                {
                    a1.history();
                }
                else
                {
                    Console.WriteLine("Invalid choice...Try again");
                }
            }
        }
    }
}
