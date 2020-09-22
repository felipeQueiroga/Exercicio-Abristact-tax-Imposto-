using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio_Abristact_tax_Imposto_.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return (AnualIncome * 0.14);
            }
            else
            {
                return (AnualIncome * 0.16);
            }
        }

        public override string ToString()
        {
            return Name
                + ": $"
                + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}