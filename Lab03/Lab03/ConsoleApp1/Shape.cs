using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Shape
    {
        private string Color;

        public Shape(string Color)
        {
            this.Color = Color;
        }

        public abstract double GetArea();

        public override string ToString()
        {
            return "Color: " + Color;
        }

    }
}
