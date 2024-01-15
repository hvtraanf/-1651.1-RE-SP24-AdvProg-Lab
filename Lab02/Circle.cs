using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Circle : Shape
    {
        public double Radius = 1.0;

        public Circle()
        {

        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public Circle(double radius, string color, bool filled)
        {
            this.Radius = radius;
            this.Color = color;
            this.Filled = filled;
        }

        public double getArea()
        {
            return this.Radius * this.Radius * Math.PI;
        }

        public double getPerimeter()
        {
            return 2*this.Radius * Math.PI;
        }

        public override string ToString()
        {
            return "A Circle with radius " + this.Radius + " which is a subclass of " + base.ToString();
        }
    }
}
