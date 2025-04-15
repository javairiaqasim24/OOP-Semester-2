using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challege05
{
    internal class BMW:Cars
    {
        private double fuelEfficiency;

        public BMW(string color, decimal price, double fuelEfficiency)
            : base("BMW", color, price)
        {
            this.fuelEfficiency = fuelEfficiency;
        }

        public double GetFuelEfficiency()
        {
            return fuelEfficiency;
        }
        public void SetFuelEfficiency(double value) => fuelEfficiency = value;

        public void CalculateFuel(double distance)
        {
            double fuelNeeded = distance / fuelEfficiency;
            Console.WriteLine($"BMW requires {fuelNeeded} liters of fuel for {distance} km.");
        }
    }
}
