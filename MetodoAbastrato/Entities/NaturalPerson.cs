using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoAbstrato.Entities
{
    internal class NaturalPerson : Person
    {
        public double HealthExpenses { get; set; }

        public NaturalPerson(double healthExpenses, string name, double income) : base (name, income)
        {
            HealthExpenses = healthExpenses;
        }

        public override double TaxTotal()
        {
            if (Income <= 20000.00)
            {
                if(HealthExpenses > 0)
                {
                    return ((Income * 0.15) - (HealthExpenses * 0.50));
                }
                else
                {
                    return (Income * 0.15);
                }
            }
            else if(Income >= 20000.00)
            {
                if (HealthExpenses > 0)
                {
                    return ((Income * 0.25) - (HealthExpenses * 0.50));
                }
                else
                {
                    return (Income * 0.25);
                }
            }
            else
            {
                Console.WriteLine("Erro: Valor vazio");
                return 0;
            }
            
        }
    
    }
}
