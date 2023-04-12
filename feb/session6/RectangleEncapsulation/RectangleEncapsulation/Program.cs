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
            Rectangle rectangleA = new Rectangle();
            rectangleA.SetWidth(101);
            rectangleA.SetHeight(-1);
            rectangleA.SetColor("black");
            PrintDetails(rectangleA, "Details of rectangle A");

            Rectangle rectangleB = new Rectangle();
            rectangleB.SetWidth(20);
            rectangleB.SetHeight(30);
            rectangleB.SetColor("GreeN");
            PrintDetails(rectangleB, "Details of rectangle B");

            Circle circleA = new Circle();
            circleA.SetRadius(10);
            circleA.SetColor("red");
            circleA.SetBorder("solid");
            Console.WriteLine("DETAIL OF CIRCLE");
            Console.WriteLine($"radius is {circleA.GetRadius()}");
            Console.WriteLine($"color is {circleA.GetColor()}");
            Console.WriteLine($"border is {circleA.GetBorder()}");
            Console.WriteLine($"area of circle is {circleA.CalculateArea()}");
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
