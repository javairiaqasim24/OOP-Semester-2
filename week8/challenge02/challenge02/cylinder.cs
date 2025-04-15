using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge02
{
    internal class cylinder:circle
    {
        private double height;

        public cylinder ()
        {

        }
        public cylinder(double radius):base(radius)
        {
            this.height = radius;
        }
        public cylinder(double height,double radius):base(radius)
        {
            this.height = height;
        }
        public cylinder(double height, double radius,string color) : base(radius,color)
        {
            this.height = height;
        }

        public double getHeight()
        {
            return this.height;
        }
        public void setHeight(double height)
        {
            this.height = height;
        }

        public double GetVolume()
        {
            return getArea()*height;
        }
    }
}
