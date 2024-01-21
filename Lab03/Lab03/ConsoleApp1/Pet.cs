using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface Pet
    {
        public string Name { get; set; }

        public void Play();
    }
}
