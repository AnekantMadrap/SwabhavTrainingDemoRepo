using CustomerEncapsulationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerEncapsulationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer person1 = new Customer(1, "chirag");
            Console.WriteLine(person1.Id);
            Console.WriteLine(person1.Name);
        }
    }
}
