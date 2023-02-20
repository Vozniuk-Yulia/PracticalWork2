using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Product
    {
        string name;
        int price;
        string category;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public Product() { }
        public Product(string name, int price,string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }
}
