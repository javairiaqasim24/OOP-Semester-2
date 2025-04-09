using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge04
{
    internal class Account
    {
        private string accountTitle;
        private string accountNumber;
        private decimal balance;

        public string GetAccountTitle() => accountTitle;
        public string GetAccountNumber() => accountNumber;
        public decimal GetBalance() => balance;

        public void SetAccountTitle(string title) => accountTitle = title;
        public void SetAccountNumber(string number) => accountNumber = number;
        public void SetBalance(decimal amount) => balance = amount;

        public Account(string title, string number, decimal initialBalance)
        {
            accountTitle = title;
            accountNumber = number;
            balance = initialBalance;
        }

        public void Credit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Credited {amount:C}. New balance: {balance:C}");
        }

        public void Debit(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Debited {amount:C}. New balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }
}
