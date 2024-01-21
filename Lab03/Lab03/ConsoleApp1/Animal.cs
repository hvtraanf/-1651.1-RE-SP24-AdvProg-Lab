using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Animal
    {
        public readonly int Legs;

        protected Animal(int Legs)
        {
            this.Legs = Legs;
        }

        public virtual void Walk()
        {
            Console.WriteLine("The animal is walking");
        }

        public abstract void Eat();
    }
}
