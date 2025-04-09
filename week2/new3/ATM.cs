using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new3
{
    public class ATM
    {

        public double balance;
        public double with;
        public double bal;
        List<string> new data =new List<string>();
        public void deposit()
        {
            Console.WriteLine("Enter the amount to deposit : ");
            bal = double.Parse(Console.ReadLine());
            balance = balance + bal;
            data.Add("Deposit Amount " + bal);
        }
        public void withdraw()
        {
            Console.WriteLine("Enter the amount to withdraw : ");
            with = double.Parse(Console.ReadLine());
            if (a1.balance > a1.with)
            {
                balance = balance - with;
                data.Add("Withdraw amount" + with);
            }
            else
            {
                Console.WriteLine("Insufficient Amount");
            }


        }
        public void check()
        {
            Console.WriteLine($"The current amount is : {balance}");
            data.Add("current Amount " + balance);
        }
        public void history()
        {
            Console.WriteLine("Data is:");
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

    }
}
