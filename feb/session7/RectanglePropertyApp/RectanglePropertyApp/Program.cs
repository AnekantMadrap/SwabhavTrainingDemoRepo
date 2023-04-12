using RectangleEncapsulation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePropertyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangleA = new Rectangle(100, 50, "green");
            PrintDetails(rectangleA, "Details of rectangle A");
            rectangleA.Color="red";
            //rectangleA.Height=50;
            PrintDetails(rectangleA, "Details of rectangle A");
        }
        static void PrintDetails(Rectangle rectangle, string v)
        {
            Console.WriteLine(v.ToUpper());
            Console.WriteLine($"width is {rectangle.Width}");
            Console.WriteLine($"height is {rectangle.Height}");
            Console.WriteLine($"color is {rectangle.Color}");
            Console.WriteLine($"area is {rectangle.CalculateArea()}");
            Console.WriteLine();

        }
    }
}
