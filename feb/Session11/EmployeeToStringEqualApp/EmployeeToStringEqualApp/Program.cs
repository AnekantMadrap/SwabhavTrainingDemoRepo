using EmployeeToStringEqualApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeToStringEqualApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Casestudy();
            var employeeA = new Employee(1, "Anekant", 1000);
            var employeeB = new Employee(1, "Anekant", 1000);
            var employeeC = employeeB;
            //reference quality
            Console.WriteLine("reference quality A & B:{0}",employeeA==employeeB);
            Console.WriteLine("reference quality c & B:{0}", employeeC == employeeB);
            Console.WriteLine("reference quality A & B:{0}", employeeA.Equals(employeeB));
            
        }

        private static void Casestudy()
        {
            var employeeA = new Employee(1, "Anekant", 1000);
            Console.WriteLine(employeeA);
            Console.WriteLine(employeeA.ToString());
            Console.WriteLine(employeeA.GetType().ToString());
        }
    }
}
