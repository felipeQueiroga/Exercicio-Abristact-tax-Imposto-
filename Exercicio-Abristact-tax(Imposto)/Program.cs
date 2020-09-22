using Exercicio_Abristact_tax_Imposto_.Entities;
using System;
using System.Collections.Generic;

namespace Exercicio_Abristact_tax_Imposto_
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            List<TaxPayer> list = new List<TaxPayer>();

            Console.WriteLine("Enter the number of tax payers:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Product #" + (i++) + " Data:");
                Console.WriteLine("Company or Individual (c/i)?");
                char type = char.Parse(Console.ReadLine());

                Console.WriteLine("Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Income:");
                double income = double.Parse(Console.ReadLine());

                if (type == 'i' || type == 'I')
                {
                    Console.WriteLine("Health expenditures:");
                    double healtExpenditures = double.Parse(Console.ReadLine());
                    TaxPayer pi = new Individual(name, income, healtExpenditures);
                    list.Add(pi);

                }
                else
                {
                    Console.WriteLine("Number of employeers:");
                    int numberImployees = int.Parse(Console.ReadLine());
                    TaxPayer pc = new Company(name, income, numberImployees);
                    list.Add(pc);
                }
            }

            //print data
            foreach (TaxPayer t in list)
            {
                Console.WriteLine(t.ToString());
            }
            Console.ReadLine();
            Console.Clear();
            goto Start;
        }
    }
}
