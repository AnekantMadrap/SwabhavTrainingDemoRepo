using EmployeePolymorphismApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(101, "vab", 2000);
            manager.CalculateAnnualSalary(0);
            Console.WriteLine(manager.Salary);

            Developer developer = new Developer(201, "wqe", 1000);
            developer.CalculateAnnualSalary(0);
            Console.WriteLine(developer.Salary);

            QualityAnalyst qualityAnalyst = new QualityAnalyst(301, "oip", 3000);
            qualityAnalyst.CalculateAnnualSalary(0);
            Console.WriteLine(qualityAnalyst.Salary);
        }
    }
}
