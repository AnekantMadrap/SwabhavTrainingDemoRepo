using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineArgsApp
{
    internal class Program
    {
        static void Main(string[] argsName)
        {
            Console.WriteLine("inside main");
            Console.WriteLine("outside main");
            int[] a = { 1, 2, 3, 4, 5 };
            int sum = 0, max = a[0],avg;
            for(int i=0;i<a.Length;i++)
            {
                sum = sum + a[i];
                if (a[i] > a[0])
                {
                    max = a[i];
                }
            }
            avg= sum / a.Length;
            Console.WriteLine(sum);
            Console.WriteLine(avg);
            Console.WriteLine(max);
            
        }
    }
}
