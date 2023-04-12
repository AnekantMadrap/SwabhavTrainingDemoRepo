using RectangleEncapsulation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstructorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDetails(new Rectangle(width:20,height:30,color:"blue"),"desc");

            Rectangle rectangleA = new Rectangle(100,20,"red");
            PrintDetails(rectangleA, "Details of rectangle A");
            rectangleA.SetColor("green");
            PrintDetails(rectangleA, "Details of rectangle A");
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
