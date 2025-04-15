using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challege05
{
    internal class Cars
    {
        private string model;
        private string color;
        private decimal price;

        public Cars(string model, string color, decimal price)
        {
            this.model = model;
            this.color = color;
            this.price = price;
        }

        public string GetModel()
        {
            return model;
        }
        public string GetColor()
        {
            return color;
        }
        public decimal GetPrice()
        {
            return price;
        }

        public void SetModel(string model)
        {
            this.model = model;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public void SetPrice(decimal price)
        {
            this.price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Model :{model},Color Of Car {color},Price of Car {price}");
        }
    }
}
