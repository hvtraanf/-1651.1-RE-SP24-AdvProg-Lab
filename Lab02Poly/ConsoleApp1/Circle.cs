using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Circle
    {
        public readonly double Radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Radius: " + Radius;
        }
    }
}
