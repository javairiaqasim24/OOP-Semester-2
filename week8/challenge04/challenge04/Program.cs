using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentAccount student = new StudentAccount("Alice", "ST123", 10000);
            student.StudentCredit(300000); // Valid
            student.StudentCredit(250000); // Exceeds limit

            SalaryAccount salary = new SalaryAccount("Bob", "SA456", 100000);
            salary.SalaryDebit(20000); // Applies 2% tax
        }
    }
}
