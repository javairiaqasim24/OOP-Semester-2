using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mountain Bike Details ...");
            MountainBike bike =new MountainBike(20,30,3,80);
            Console.WriteLine($"SeatHeight :{bike.getSeatHeight()},Cadence is :{bike.getcandence()}");

        }
    }
}
