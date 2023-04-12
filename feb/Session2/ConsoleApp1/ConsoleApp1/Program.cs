using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start main");
            Console.WriteLine(args.Length);
            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
            foreach(string name in args)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("end main");
        }
    }
}
