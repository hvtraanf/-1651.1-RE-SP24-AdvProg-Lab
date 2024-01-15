using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Shape
    {
        public string Color = "Red";
        public bool Filled = true;

        public Shape() { }
        
        public Shape(string color, bool filled)
        {
            this.Color = color;
            this.Filled = filled;
        }

        public override string ToString()
        {
            string isFilled = (Filled) ? isFilled = "filled" : isFilled = "not filled";

            return "A Shape with color of " + this.Color + " and " + isFilled;
        }

    }
}
