using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dryapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            smallrectangle();
            largerectangle();
        }

        public static void area(int a,int b)
        {
            Console.WriteLine("length is {0} and breadth is {1}", a, b);
            int area = a*b;
            Console.WriteLine("area of rectangle is {0}",area);
            
        }
        public static void smallrectangle() 
        {
            int a = 10, b = 20;            
            area(a, b);
        }
        public static void largerectangle()
        {
            int a = 30, b = 20;
            area(a, b);
        }
    }
}
