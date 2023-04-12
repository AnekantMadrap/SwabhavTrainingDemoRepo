using RectangleEncapsulation.Model;
//using CircleEncapsulation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Rectangle A");
            Console.WriteLine(new Rectangle().CalculateArea());
            PrintDetails(new Rectangle(), "anonymous object");

            Rectangle re = new Rectangle();
            //re.SetHeight(100);
            re.SetWidth(20);
            re.SetColor("red");
            PrintDetails(re, "akv");
            //PrintDetails(null, null);

        }

        static void PrintDetails(Rectangle rectangle, string v)
        {
            Console.WriteLine(v.ToUpper());
            Console.WriteLine($"width is {rectangle.GetWidth()}");
            Console.WriteLine($"height is {rectangle.GetHeight()}");
            Console.WriteLine($"color is {rectangle.GetColor()}");
            Console.WriteLine($"area is {rectangle.CalculateArea()}");
            Console.WriteLine();

        }
    }
}
