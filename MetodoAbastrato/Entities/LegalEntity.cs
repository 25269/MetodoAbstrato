using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoAbstrato.Entities
{
    internal class LegalEntity : Person
    {
        public int Employees { get; set; }

        public LegalEntity(int employees, string name, double income) : base (name, income)
        {
            Employees = employees; 
        }

        public override double TaxTotal()
        {
            if(Employees >= 10)
            {
                return Income * 0.14;
            }
            else
            {
                return Income * 0.16;
            }
        }

    }
}
