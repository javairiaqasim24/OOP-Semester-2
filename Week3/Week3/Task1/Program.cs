using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h = 0, m = 0, s = 0;
            Console.WriteLine("Enter Current Time");
            TakeInput(ref h, ref m, ref s);

            ClockType clock = new ClockType();
            Console.Write("Empty Time: ");
            clock.PrintTime();

            ClockType clock1 = new ClockType(h, m, s);
            Console.Write("Current Time: ");
            clock1.PrintTime();

            Console.WriteLine("Elapsed Time: " + clock1.ElapseTime());


            Console.Write("Remaining Time: ");
            clock1.RemainingTime();

            Console.WriteLine("");
            Console.WriteLine("Enter Time of Clock 1");
            TakeInput(ref h, ref m, ref s);
            ClockType clock3 = new ClockType(h, m, s);

            Console.WriteLine("Enter Time of Clock 2");
            TakeInput(ref h, ref m, ref s);
            ClockType clock4 = new ClockType(h, m, s);

            Console.Write("Time After Difference: ");
            ClockType.TimeDifference(clock3, clock4);

        }
        static void TakeInput(ref int h, ref int m, ref int s)
        {
            Console.WriteLine("Enter Hours: ");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Minutes: ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Seconds: ");
            s = int.Parse(Console.ReadLine());
        }
    }
}
