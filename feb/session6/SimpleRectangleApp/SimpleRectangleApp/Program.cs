using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rectangleapp.Model;

namespace SimpleRectangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangleA;
            rectangleA = new Rectangle();
            PrintDetails(rectangleA,"detail of rectangle a before initlizing value");
            /*Console.WriteLine($"width is {rectangleA.width} " +
                $"heigth is {rectangleA.height} " + $"color is {rectangleA.color} "
                + $"area is {rectangleA.CalculateArea()} ");*/

            rectangleA.width = 10;
            rectangleA.height = 20;
            rectangleA.color = "blue";

            PrintDetails(rectangleA, "detail of rectangle a after initlizing value");
            /*Console.WriteLine($"width is {rectangleA.width} " +
                $"heigth is {rectangleA.height} " + $"color is {rectangleA.color} "
                + $"area is {rectangleA.CalculateArea()} ");*/

            Rectangle rectangleB;
            rectangleB = rectangleA;

            PrintDetails(rectangleB,"rectangle B");
            /*Console.WriteLine($"width is {rectangleB.width} " +
                $"heigth is {rectangleB.height} " + $"color is {rectangleB.color} "
                + $"area is {rectangleB.CalculateArea()} ");*/
            rectangleB.color= "red";

            Console.WriteLine($"color of rectangle B is {rectangleB.color} hashcode is {rectangleB.GetHashCode()}");
            Console.WriteLine($"color of rectangle A is {rectangleA.color} hashcode is {rectangleA.GetHashCode()}");


        }

        static void PrintDetails(Rectangle rectangle, string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine($"width is {rectangle.width} "+
                $"height is {rectangle.height} "+
                $"color is {rectangle.color}"+
                $"area is {rectangle.CalculateArea()}");
        }
    }
}
