using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Fish : Animal
    {
        public string Name;

        public Fish(string Name) : base(0)
        {
            this.Name = Name;
        }

        public void Play()
        {
            Console.WriteLine("The fish is playing");
        }

        public override void Eat()
        {
            Console.WriteLine("The fish is eating");
        }

        public override void Walk()
        {
            Console.WriteLine("The fish cannot walk");
        }
    }
}
