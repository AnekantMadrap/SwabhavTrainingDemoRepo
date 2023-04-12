using AdditionClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int ab = Class1.Sum(2, 3);
            Console.WriteLine(ab);*/

            Class1 ab = new Class1();
            Console.WriteLine($"Addition of number is {ab.Add(2,3)}");

        }
    }
}
