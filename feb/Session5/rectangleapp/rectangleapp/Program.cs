using rectangleapp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangleapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle small= new Rectangle();
            small.width= 10;
            small.height= 20;
            Console.WriteLine("width of small rectangle is {0}",small.width);
            Console.WriteLine("height of small rectangle is {0}", small.height);
            Console.WriteLine("area of small rectangle is {0}",small.CalculateArea());
            Rectangle large = new Rectangle();
            large.width = 30;
            large.height = 20;
            Console.WriteLine("width of large rectangle is {0}", large.width);
            Console.WriteLine("height of large rectangle is {0}", large.height);
            Console.WriteLine("area of large rectangle is {0}", large.CalculateArea());
        }
    }
}
