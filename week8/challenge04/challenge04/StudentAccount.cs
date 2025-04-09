using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge04
{
    internal class StudentAccount:Account
    {
        private const decimal MaxCreditLimit = 500000;

        public StudentAccount(string title, string number, decimal balance)
            : base(title, number, balance) { }

        
        public void StudentCredit(decimal amount)
        {
            if (GetBalance() + amount <= MaxCreditLimit)
            {
                Credit(amount);
            }
            else
            {
                Console.WriteLine("Credit limit exceeded. Max allowed: 500,000");
            }
        }
    }
}
