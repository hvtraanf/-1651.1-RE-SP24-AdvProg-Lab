using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Point2d
    {
        public int x = 0;
        public int y = 0;

        public Point2d()
        {

        }

        public Point2d(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "X: " + x + "Y: " + y;
        }
    }
}
