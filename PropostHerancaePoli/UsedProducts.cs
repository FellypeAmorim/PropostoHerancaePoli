using System;
using System.Collections.Generic;
using System.Text;

namespace PropostHerancaePoli
{
    class UsedProducts : Product
    {
        public DateTime Manufacturetime { get; set; }

        public UsedProducts()
        {
        }

        public UsedProducts(string name, double price, DateTime manufacturetime) : base(name, price)
        {
            Manufacturetime = manufacturetime;
        }

        public override string Pricetag()
        {
            return Name + " (used) R$" + Price.ToString("F2") + " (Manufacture Date: " + Manufacturetime.ToString("dd/MM/yyyy") + ")";
        }
    }
}
