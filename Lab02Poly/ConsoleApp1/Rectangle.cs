using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rectangle : Shape
    {
        private int length;
        private int width;

        public Rectangle(string color, int length, int width) : base(color)
        {
            this.length = length;
            this.width = width;
        }

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public override double getArea()
        {
            return length * width;
        }

        public override string ToString()
        {
            return "Length: " + length + " Width: " + width + " " + base.ToString();
        }
    }
}
