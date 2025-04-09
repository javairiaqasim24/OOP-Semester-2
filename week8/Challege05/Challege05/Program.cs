using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challege05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BMW bmwCar = new BMW("Black", 8000000, 12.5);
            bmwCar.DisplayInfo();
            bmwCar.CalculateFuel(150); // 150 km

            Console.WriteLine();

            Audi audiCar = new Audi("Red", 7500000, 8.2);
            audiCar.DisplayInfo();
            audiCar.EstimateFuelUsage(150); // 150 km
        }
    }
}
