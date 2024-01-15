using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Shape
    {
        private string color;

        public Shape(string color)
        {
            this.color = color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public virtual double getArea()
        {
            return 0.0;
        }

        public override string ToString()
        {
            return "Color: " + color;
        }
    }
}
