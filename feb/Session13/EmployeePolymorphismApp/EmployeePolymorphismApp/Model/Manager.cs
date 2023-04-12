using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    internal class Manager : Employee
    {
        private double HRA;
        private double TA;
        private double DA;
        public Manager(int id, string name, double basicaslary) : base(id, name, basicaslary)
        {
            double HRA = 0.6 * _basicaslary;
            CalculateAnnualSalary(HRA);
            double TA = 0.5 * _basicaslary;
            CalculateAnnualSalary(TA);
            double DA = 0.4 * _basicaslary;
            CalculateAnnualSalary(DA);

        }

        

    }
}
