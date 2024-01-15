using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Square : Rectangle
    {
        public double Side { get { return Width; } set { Width = value; Length = value; } }

        public Square(double side)
        {
            this.Side = side;
        }

        public override string ToString()
        {
            return "A Square with side " + Side + " which is a subclass of " + base.ToString();
        }
    }
}
