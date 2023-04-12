using DifferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Odd odd = new Odd(100, 200);
            PrintDetails(odd, "odd value:");
            Console.WriteLine();
            Odd odd1 = new Odd(200);
            PrintDetails(odd1, "odd value:");
            Console.WriteLine();
            Even even = new Even(100, 200);
            PrintDetails(even, "even value:");
            Console.WriteLine();
            Even even1 = new Even(100);
            PrintDetails(even1, "even value:");
            Console.WriteLine();

        }

       /* private static void CaseStudy4()
        {
            Even even = new Even(100);
            PrintDetails(even , "even value:");
            Console.WriteLine();
        }

        private static void CaseStudy3()
        {
            Even even = new Even(100, 200);
            PrintDetails(even,"even value:");
            Console.WriteLine();
        }

        private static void CaseStudy2()
        {
            Odd odd = new Odd(200);
            PrintDetails(odd,"odd value:");
            Console.WriteLine();
        }

        private static void CaseStudy1()
        {
            Odd odd = new Odd(100,200);
            PrintDetails(odd,"odd value:");
            Console.WriteLine();

        }*/
        static void PrintDetails(Odd odd,string description)
        {
            Console.WriteLine(description.ToUpper());
            foreach(int n in odd.Number)
            {
                Console.Write(n + " ");

            }
            Console.WriteLine();
        }
        static void PrintDetails(Even even, string description)
        {
            Console.WriteLine(description.ToUpper());
            for (int i=0;i<even.Number.Length;i++)
            {
                Console.Write(even.Number[i]+" ");
                
            }
            Console.WriteLine();
            
        }
    }
}
