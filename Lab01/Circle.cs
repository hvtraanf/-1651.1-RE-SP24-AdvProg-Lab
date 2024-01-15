using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab01
{
    internal class Circle
    {
        public double radius = 1.0d;
        public double area;
        public double circumference;

        public Circle()
        {

        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double getArea()
        {
            this.area = this.radius * Math.PI;
            return this.area;
        }

        public double getCircumference()
        {
            this.circumference = this.radius * Math.PI * 2;
            return this.circumference;
        }

        public override string ToString()
        {
            return "Circle radius: " + radius;
        }
    }
}
