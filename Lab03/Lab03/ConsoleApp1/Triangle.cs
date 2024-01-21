using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Triangle : Shape
    {
        private int Base;
        private int Height;

        public Triangle(string Color, int Base, int Height) : base(Color)
        {
            this.Base = Base;
            this.Height = Height;
        }

        public override double GetArea()
        {
            return (Base * Height)/2;
        }

        public override string ToString()
        {
            return base.ToString() + ", Base: " + Base + ", Height: " + Height;
        }
    }
}
