using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Teacher : Person
    {
        private int NumCourses = 0;
        private string[] courses = { };

        public Teacher(string name, string address) : base(name)
        {
            this.Address = address;
        }

        public bool AddCourse(string course)
        {
            
        }
    }
}
