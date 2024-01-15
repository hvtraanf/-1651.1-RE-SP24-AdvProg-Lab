using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Rectangle : Shape
    {
        public double Width = 1.0;
        public double Length = 1.0;

        public Rectangle() { }

        public Rectangle(double width, double length)
        {
            this.Width = width;
            this.Length = length;
        }

        public Rectangle(double width, double length, string color, bool filled)
        {
            this.Width = width;
            this.Length = length;
            this.Color = color;
            this.Filled = filled;
        }

        public double getArea()
        {
            return this.Width * this.Length;
        }

        public double getPerimeter()
        {
            return 2 * (this.Width + this.Length);
        }

        public override string ToString()
        {
            return "A Rectangle with width " + this.Width + " and length " + this.Length + " which is a subclass of " + base.ToString();
        }
    }
}
