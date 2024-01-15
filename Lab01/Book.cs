using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Book
    {
        public readonly string Name;
        public readonly Author Author;
        public double Price;
        public int Quantity=0;

        public Book(string name, Author author, double price)
        {
            this.Name = name;
            this.Author = author;
            this.Price = price;
        }

        public Book(string name, Author author, double price, int quantity)
        {
            this.Name = name;
            this.Author = author;
            this.Price = price;
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            return "Name: " + this.Name + " " + this.Author + " Price: " + this.Price + " Quantity: " + this.Quantity;
        }
    }
}
