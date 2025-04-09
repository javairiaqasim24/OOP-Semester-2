using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge04
{
    internal class SalaryAccount:Account
    {
        private const decimal TaxRate = 0.02m;

        public SalaryAccount(string title, string number, decimal balance)
            : base(title, number, balance) { }

        // Salary-specific debit logic (no override)
        public void SalaryDebit(decimal amount)
        {
            decimal tax = amount * TaxRate;
            decimal totalAmount = amount + tax;

            if (GetBalance() >= totalAmount)
            {
                SetBalance(GetBalance() - totalAmount);
                Console.WriteLine($"Debited {amount:C} with tax {tax:C}. New balance: {GetBalance():C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds (including tax).");
            }
        }
    }
}
