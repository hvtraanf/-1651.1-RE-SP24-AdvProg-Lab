using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cylinder : Circle
    {
        public readonly double Height;

        // Constructor
        public Cylinder(double radius, double height) : base(radius)
        {
            Height = height;
        }

        // Method to calculate volume for cylinders
        public double GetVolume()
        {
            return GetArea() * Height;
        }

        // Method to calculate lateral surface area for cylinders
        public double GetArea()
        {
            return 2 * Math.PI * Radius * Height;
        }

        // Additional constructor with a default radius
        public Cylinder(double height) : this(radius: 1.0, height) { }

        public override string ToString()
        {
            return "Radius: " + this.Radius + " Height: " + this.Height;
        }
    }
}
