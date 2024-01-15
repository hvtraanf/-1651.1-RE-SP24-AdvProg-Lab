using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Triangle : Shape
    {
        private int triangleBase;
        private int height;

        public Triangle(string color, int triangleBase, int height) : base(color)
        {
            this.triangleBase = triangleBase;
            this.height = height;
        }

        public int Base
        {
            get { return triangleBase; }
            set { triangleBase = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public override double getArea()
        {
            return 0.5 * triangleBase * height;
        }

        public override string ToString()
        {
            return "Base: " + triangleBase + " Height: " + height + " " + base.ToString();
        }
    }
}
