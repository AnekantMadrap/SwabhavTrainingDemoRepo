using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    internal class Developer:Employee
    {
        private double PA;
        private double OTA;

        public Developer(int id, string name, double basicaslary) : base(id, name, basicaslary)
        {
            double PA = 0.5 * _basicaslary;
            CalculateAnnualSalary(PA);
            double OTA = 0.4 * _basicaslary;
            CalculateAnnualSalary(OTA);
        }

         
    }
}
