using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cat : Animal
    {
        public string Name;

        public Cat() : base(4)
        {

        }

        public Cat(string name) : base(4)
        {
            this.Name= name;
        }

        public void Play()
        {
            Console.WriteLine("The cat is playing");
        }

        public override void Eat()
        {
            Console.WriteLine("The cat is eating");
        }
    }
}
