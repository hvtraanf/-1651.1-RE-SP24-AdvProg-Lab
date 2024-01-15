using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Employee
    {
        public readonly int ID;
        public readonly string FirstName;
        public readonly string LastName;
        public int Salary;
        public string FullName;
        public int AnnualSalary;
        public double NewSalary;
        public int OldSalary;

        public Employee(int iD, string firstName, string lastName, int salary)
        {
            this.ID = iD;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }

        public string getFullName()
        {
            this.FullName = this.FirstName + " " + this.LastName;
            return FullName;
        }

        public int getAnnualSalary()
        {
            this.AnnualSalary = this.Salary * 12;
            return this.AnnualSalary;
        }

        public double raiseSalary(double percent)
        {
            this.OldSalary = this.Salary;
            this.NewSalary = this.Salary*(1+(percent/100.0));
            this.Salary = (int)this.NewSalary;
            return this.NewSalary;
        }

        public override string ToString()
        {
            return "Employee: " + this.ID + " " + this.FullName + " Old Salary: " + this.OldSalary + " New Salary: " + this.Salary;
        }
    }
}
