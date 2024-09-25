using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MetodoAbstrato.Entities
{
    abstract class Person
    {
        public String Name { get; set; }
        public double Income { get; set; }

        public Person(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double TaxTotal();
    }
}
