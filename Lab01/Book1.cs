using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Book1
    {
        public readonly string Name;
        public readonly Author[] Author;
        public double Price;
        public int Quantity = 0;

        public Book1(string name, Author[] author, double price)
        {
            this.Name = name;
            this.Author = author;
            this.Price = price;
        }

        public Book1(string name, Author[] author, double price, int quantity)
        {
            this.Name = name;
            this.Author = author;
            this.Price = price;
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Name: ").Append(this.Name);
            for (int i = 0; i < this.Author.Length; i++)
            {
                sb.Append(" ").Append(this.Author[i].ToString());
            }
            sb.Append(" ").Append(this.Price).Append(" ").Append(this.Quantity);

            return sb.ToString();
        }
    }
}
