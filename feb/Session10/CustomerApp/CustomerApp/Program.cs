using System;
using CustomerApp.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("a", 100);
            Customer c2 = new Customer("b", 100);
            Customer c3 = new Customer("c", 100);
            Console.WriteLine(c1.Id);
            Console.WriteLine(c2.Id);
            Console.WriteLine(c3.Id);
            Customer c4 = new Customer("d", 100);
            Console.WriteLine(c1.Id);
            Console.WriteLine(c2.Id);
            Console.WriteLine(c3.Id);
            Console.WriteLine(c4.Id);

        }
    }
}
