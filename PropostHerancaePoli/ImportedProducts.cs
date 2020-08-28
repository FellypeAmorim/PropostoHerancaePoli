using System;
using System.Collections.Generic;
using System.Text;

namespace PropostHerancaePoli
{
    class ImportedProducts : Product
    {
        public double Customsfee { get; set; }

        public ImportedProducts()
        {
        }

        public ImportedProducts(string name, double price, double customsfee) : base (name, price)
        {
            Customsfee = customsfee;
        }



        public override string Pricetag()
        {
            return Name + " R$" + Totalprice().ToString("F2") + " (Customs fee: R$" + Customsfee + ")";
        }

        public double Totalprice()
        {
            
           return Price + Customsfee;
        }
    }
}
