using Imposto.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imposto.Entities
{
    class Funcionario : Contribuintes
    {
        public double HealthCost { get; set; }

        public Funcionario(String name, double AnualIcome, double healthcost)
            : base(name, AnualIcome)
        {
            if (name == null || AnualIcome == null)
            {
                throw new DomainException("Nome e Ganho Anual não pode ser valores nulos...");
            }

            this.HealthCost = healthcost;
        }


        // calcula o ganho do funcionário já descontando o imposto
        public override double Tax()
        {
            if (anualIcome < 20000)
            {
                double tax = anualIcome * 0.15;
                double health = this.HealthCost / 2;
                tax -= health;

                return tax;
            }
            else
            {
                double tax = anualIcome * 0.25;
                double health = this.HealthCost / 2;
                tax -= health;

                return tax;
            }
        }

        public override string ToString()
        {
            return this.Name
                + " $ " + this.Tax().ToString("F2");
        }
    }
}
