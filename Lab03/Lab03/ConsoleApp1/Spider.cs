using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Spider : Animal
    {
        public Spider() : base(8)
        {
            
        }

        public override void Eat()
        {
            Console.WriteLine("The Spider is eating");
        }
    }
}
