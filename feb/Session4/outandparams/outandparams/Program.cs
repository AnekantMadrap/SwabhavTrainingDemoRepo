using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outandparams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Casestudy1();
            //Casestudy2();
        }

        public static void Casestudy1()
        {
            int[] a= { 1, 2,3 };
            Console.WriteLine("array follows params parameter");
            paramlist(a);
            int x = 10, y = 10;
            outfun(in x, in y, out int sum, out int pro);
            Console.WriteLine("sum is {0},pro is {1}", sum, pro);
            String s = "20";
            tryparse(s);
        }

        public static void paramlist(params int[] a)
        {
            foreach(int i in a)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }

        public static void tryparse(string s)
        {
            int.TryParse(s, out int value);
            Console.WriteLine("tryparse of string is",value);
            //Console.WriteLine("sum is {0},pro is {1}",sum,pro);
        }
        
        public static void outfun(in int a,in int b,out int sum,out int pro)
        {
            //a = 10;
            //b=20;
            sum=a+b;
            pro = a * b;
        }
    }
}
