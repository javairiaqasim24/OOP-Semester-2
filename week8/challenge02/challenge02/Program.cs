using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            cylinder cyl1 = new cylinder(10.0, 5.0);
            Console.WriteLine("Cylinder 1:");
            Console.WriteLine("Radius: " + cyl1.getRadius());
            Console.WriteLine("Height: " + cyl1.getHeight());
            Console.WriteLine("Volume: " + cyl1.GetVolume());
            Console.WriteLine();

            
            cylinder cyl2 = new cylinder(7.0, 4.0, "Blue");
            Console.WriteLine("Cylinder 2:");
            Console.WriteLine("Radius: " + cyl2.getRadius());
            Console.WriteLine("Height: " + cyl2.getHeight());
            Console.WriteLine("Color: " + cyl2.getColor());
            Console.WriteLine("Volume: " + cyl2.GetVolume());

            Console.ReadLine();

        }
    }
}
