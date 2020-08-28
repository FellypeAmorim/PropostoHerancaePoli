using System;
using System.Collections.Generic;
using System.Text;

namespace PropostHerancaePoli
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string Pricetag()
        {
            return Name + " R$" + Price.ToString("F2");
        }
    }
}
