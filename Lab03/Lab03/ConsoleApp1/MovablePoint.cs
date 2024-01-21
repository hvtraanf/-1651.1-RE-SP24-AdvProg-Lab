using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MovablePoint : IMovable
    {
        private int X;
        private int Y;

        public MovablePoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void MoveUp()
        {
            Y++;
        }

        public void MoveDown()
        {
            Y--;
        }

        public void MoveLeft()
        {
            X--;
        }

        public void MoveRight()
        {
            X++;
        }


        public override string ToString()
        {
            return "The Point's position: X: " + X + " Y: " + Y;
        }

    }
}
