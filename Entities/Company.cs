using System;
using System.Collections.Generic;
using System.Text;
using Imposto.Entities.Exceptions;

namespace Imposto.Entities
{
    class Company : Contribuintes
    {
        public int EmployeerNumber { get; set; }

            public Company(string name, double AnualIncome, int EmpNumber)
            :base (name, AnualIncome)
        {
            if (name ==null || AnualIncome== null)
            {
                throw new DomainException("Nome e Ganho Anual não pode ser valores nulos...");
            }
            this.EmployeerNumber = EmpNumber;
        }




        public override double Tax()
        {
            if (EmployeerNumber < 10)
            {
                 double tax = this.anualIcome * 0.16;
                return tax;
            }
            else
            {
                double tax = this.anualIcome * 0.14;
                return tax;
            }

            
        }
        public override string ToString()
        {
            return this.Name
                + " $" + Tax().ToString("F2");
        }


    }
}
