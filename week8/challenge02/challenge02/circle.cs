using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge02
{
    internal class circle
    {
        private double radius;
        private string color;

        public circle()
        {

        }
        public circle(double radius)
        { 
            this.radius = radius; 
        }

       public circle(double radius, string color)
       {
            this.radius = radius;
            this.color = color;
       }

        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public string getColor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }

        public double getArea()
        {
            return 3.14 * (radius * radius);
        }
    }
}
