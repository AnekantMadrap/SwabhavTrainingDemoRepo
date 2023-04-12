using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStatsCommandLine
{
    internal class Program
    {
        static void Main(string[] argsOfName)
        {
            
            Console.WriteLine("count:{0} ",argsOfName.Length);
            int max = 0;
            int sum = 0;
            foreach (string arg in argsOfName)
            {
               
                sum =sum + Convert.ToInt32(arg);
                if(max < Convert.ToInt32(arg))
                {
                    max= Convert.ToInt32(arg) ;
                }
            }
            int avg=sum/argsOfName.Length;
            Console.WriteLine("sum: {0}",sum);
            Console.WriteLine("max:{0}",max);
            Console.WriteLine("average:{0}",avg);
        }
    }
}
