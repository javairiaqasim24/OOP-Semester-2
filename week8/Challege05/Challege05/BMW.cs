using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challege05
{
    internal class BMW:Cars
    {
        private double fuelEfficiency; // in km/l

        public BMW(string color, decimal price, double fuelEfficiency)
            : base("BMW", color, price)
        {
            this.fuelEfficiency = fuelEfficiency;
        }

        public double GetFuelEfficiency() => fuelEfficiency;
        public void SetFuelEfficiency(double value) => fuelEfficiency = value;

        public void CalculateFuel(double distance)
        {
            double fuelNeeded = distance / fuelEfficiency;
            Console.WriteLine($"BMW requires {fuelNeeded:F2} liters of fuel for {distance} km.");
        }
    }
}
