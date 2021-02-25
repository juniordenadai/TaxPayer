using System;
using System.Globalization;
using System.Collections.Generic;
using TaxApp.Entities;


namespace TaxApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> payers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company(i / c)? ");
                char typeTax = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (typeTax == 'i' || typeTax == 'I')
                {
                    Console.WriteLine("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    payers.Add(new Individual(name, anualIncome, healthExpenditures));

                }
                else 
                { 
                    Console.WriteLine("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    payers.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine("TAXES PAIED");
            foreach(TaxPayer taxPayer in payers)
            {
                Console.WriteLine(taxPayer);
            }
        }
    }
}
