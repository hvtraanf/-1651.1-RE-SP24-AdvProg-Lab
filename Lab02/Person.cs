using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Person
    {
        public readonly string Name;
        public string Address { get; set; } 

        public Person(string name)
        {
            this.Name = name;
        }


        public override string ToString()
        {
            return "Name: " + Name + " Address: " + Address;
        }
    }
}
