using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge04
{
    internal class SalaryAccount:Account
    {
        private decimal TaxRate;

        public SalaryAccount(string title, string number, decimal balance)
            : base(title, number, balance) 
        {
            TaxRate = 0.02m;
        }

        
        public void SalaryDebit(decimal amount)
        {
            decimal tax = amount * TaxRate;
            decimal totalAmount = amount + tax;

            if (GetBalance() >= totalAmount)
            {
                SetBalance(GetBalance() - totalAmount);
                Console.WriteLine($"Debited {amount} with tax {tax}. New balance: {GetBalance()}");
            }
            else
            {
                Console.WriteLine("Insufficient funds (including tax).");
            }
        }
    }
}
