using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rectangle : Shape
    {
        private int Length;
        private int Width;

        public Rectangle(string Color, int Length, int Width) : base(Color)
        {
            this.Length = Length;
            this.Width = Width;
        }

        public override double GetArea()
        {
            return Length * Width;
        }

        public override string ToString()
        {
            return base.ToString() + " Width: " + Width + " Length: " + Length;
        }
    }
}
