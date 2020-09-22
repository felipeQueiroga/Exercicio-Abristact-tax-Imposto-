using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio_Abristact_tax_Imposto_.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.00)
            {
                return (AnualIncome * 0.15) - (HealthExpenditures * 0.50);
            }
            else
            {
                return (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
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
