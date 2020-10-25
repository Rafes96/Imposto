using System;
using System.Collections.Generic;
using System.Text;

namespace Imposto.Entities
{
    abstract class Contribuintes
    {

        public string Name { get; set; }
        public double  anualIcome { get; set; }

        protected Contribuintes(string name, double anualIcome)
        {
            Name = name;
            this.anualIcome = anualIcome;
        }

        public abstract double Tax();


        public override string ToString()
        {
            return "Taxex Paid: \n"+
                "Name: " + this.Name
                + " $ " + this.Tax().ToString("F2");
        }

    }
}
