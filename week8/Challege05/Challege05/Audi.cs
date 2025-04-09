using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challege05
{
    internal class Audi:Cars
    {
        private double fuelRatePer100Km; // in liters/100km

        public Audi(string color, decimal price, double fuelRate)
            : base("Audi", color, price)
        {
            this.fuelRatePer100Km = fuelRate;
        }

        public double GetFuelRate() => fuelRatePer100Km;
        public void SetFuelRate(double value) => fuelRatePer100Km = value;

        public void EstimateFuelUsage(double distance)
        {
            double fuelUsed = (fuelRatePer100Km / 100) * distance;
            Console.WriteLine($"Audi will consume {fuelUsed:F2} liters for {distance} km.");
        }
    }
}
