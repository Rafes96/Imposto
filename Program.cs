using Imposto.Entities;
using Imposto.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Imposto
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                List<Contribuintes> list = new List<Contribuintes>();

                Console.WriteLine("Enter the number of tax payers");
                int payers = int.Parse(Console.ReadLine());

                for (int i = 1; i <= payers; i++)
                {

                    Console.WriteLine($"Tax payer N°{i}");
                    Console.WriteLine("Individual or Company (i/c)?");
                    char ch = char.Parse(Console.ReadLine());

                    Console.WriteLine("Name");
                    string name = Console.ReadLine();

                    Console.WriteLine("Anual Income");
                    double income = double.Parse(Console.ReadLine());

                    if (ch == 'i' || ch == 'I')
                    {
                        Console.WriteLine("Helath expenditures");
                        double health = double.Parse(Console.ReadLine());

                        list.Add(new Funcionario(name, income, health));
                    }

                    else
                    {
                        Console.WriteLine("Number of employeers");
                        int employer = int.Parse(Console.ReadLine());

                        list.Add(new Company(name, income, employer));
                    }
                }
                double totalTaxes = 0;
                foreach (Contribuintes item in list)
                {
                    Console.WriteLine(item);
                    totalTaxes += item.Tax();
                }
                Console.WriteLine("Total Taxes: $" + totalTaxes.ToString("F2"));
            }

            catch (FormatException e)
            {
                Console.WriteLine("ops, algo digitado errado ... ");
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error..." + e.Message);
            }
        }
    }
}
