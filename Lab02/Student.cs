using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Student : Person
    {
        private int NumCourses = 0;
        private string[] Courses;
        private int[] Grades;

        public Student(string name, string address) : base(name)
        {
            this.Address = address;
            this.Courses = new string[5];
            this.Grades = new int[5];    
        }

        public void AddCourseGrade(string course, int grade)
        {
            for (int i = 0; i < this.Courses.Length; i++)
            {
                if (this.Courses[i] == null)
                {
                    this.Courses[i] = course;
                    this.Grades[i] = grade;
                    this.NumCourses++;
                    break;
                }
            }
        }

        public void PrintGrades()
        {
            Console.WriteLine("Grades:");
            for (int i = 0; i < this.Courses.Length; i++)
            {
                if (this.Courses[i] != null)
                {
                    Console.WriteLine($"{this.Courses[i]}: {this.Grades[i]}");
                }
            }
        }

        public double GetGradesAverage()
        {
            double sum = 0.0;

            if (this.NumCourses == 0)
            {
                return sum;
            }
            else
            {
                for (int i = 0; i < this.Grades.Length; i++)
                {
                    if (this.Grades[i] != 0)
                    {
                        sum += Grades[i];
                    }
                }
            }

            return sum / this.NumCourses;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
