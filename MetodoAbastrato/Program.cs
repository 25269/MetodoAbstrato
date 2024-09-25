
using MetodoAbstrato.Entities;
using System;
using System.Globalization;

//Namespace
namespace MetodoAbstrato
{
    //Classe
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> person = new List<Person>();
            double taxTotalObjects = 0;

            Console.Write("Enter the number of tax payers: ");
            int payers = int.Parse(Console.ReadLine());

            for(int i = 0; i < payers; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data: ");
                Console.Write("Individual or company (i/c)? ");
                char personType = char.Parse(Console.ReadLine());

                if(personType == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Anual income: ");
                    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Health expenditures: ");
                    double expenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    person.Add(new NaturalPerson(expenses, name, income));
                }
                else if (personType == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Anual income: ");
                    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    person.Add(new LegalEntity(employees, name, income));
                }
                else
                {
                    Console.WriteLine("There type is not exist");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("TAXES PAID");
            foreach(Person p in person)
            {
                Console.WriteLine($"{p.Name}: $ {p.TaxTotal().ToString("F2", CultureInfo.InvariantCulture)}");
                taxTotalObjects += p.TaxTotal();
            }

            Console.WriteLine("");
            Console.Write($"TOTAL TAXES: $ {taxTotalObjects.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("");

        }
    }
}