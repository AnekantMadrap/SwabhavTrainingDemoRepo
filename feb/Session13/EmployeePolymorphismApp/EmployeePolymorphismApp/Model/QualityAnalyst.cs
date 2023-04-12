using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    internal class QualityAnalyst : Employee
    {
        public QualityAnalyst(int id, string name, double basicaslary) : base(id, name, basicaslary)
        {
            double PERK = 0.4 * _basicaslary;
            CalculateAnnualSalary(PERK);
        }
    }
}
