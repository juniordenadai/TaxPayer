using System;
using System.Collections.Generic;
using System.Text;

namespace TaxApp.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer() { }

        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();

        public override string ToString()
        {
            return "Name: "
                + Name
                + " Annual Income: $ "
                + AnualIncome.ToString("F2")
                + " Taxes: $ "
                + Tax().ToString("F2");
        }
    }

    
}
