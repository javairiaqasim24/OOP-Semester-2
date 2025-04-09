using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labAssesment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            product s1=new product();
            s1.TrancsactionId = 1;
            s1.Name = "ali";
            s1.amount = 20000;
            s1.date = "15 feb";
            s1.time = "8'o clock";
            product s2 = s1;
            s2.TrancsactionId = 4;
            s2.Name = "ahmad";
            s2.amount = 230;
            s2.date = "15 january";
            s2.time = "9'o clock";
            Console.WriteLine(s1.Name);

        }
    }
}
