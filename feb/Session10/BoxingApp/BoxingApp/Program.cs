using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boxing();
            Unboxing();
        }

        private static void Unboxing()
        {
            Object[] obxItem = new Object[3];
            obxItem[0] = 19;
            obxItem[1] = 29;
            obxItem[2] = 18;

            int sum = 0;
            foreach(Object item in obxItem)
            {
                int unbox = (int)item;
                sum =sum + unbox;
            }
            Console.WriteLine("Unboxing "+sum);
        }

        private static void Boxing()
        {
            int[] items = { 1, 2,3,4 };
            Object Box = null;
            Console.WriteLine("boxing");
            for(int i = 0; i < 4; i++)
            {
                Box = (Object)items[i];
                Console.WriteLine(Box);
            }
            
        }
    }
}
