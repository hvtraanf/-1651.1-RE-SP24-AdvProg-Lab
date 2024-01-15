using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Point3d : Point2d
    {
        public int z = 0;

        public Point3d()
        {

        }

        public Point3d(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return "X: " + this.x + " Y: " + this.y + " Z: " + this.z;
        }
    }
}
