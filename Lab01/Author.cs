using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Author
    {
        public readonly string Name;
        public string Email;
        public readonly char Gender;

        public Author(string name, string email, char gender)
        {
            this.Name = name;
            this.Email = email;
            this.Gender = gender;
        }

        public override string ToString()
        {
            return "Author Name: " + this.Name + " Email: " + this.Email + " Gender: " + this.Gender;
        }
    }
}
