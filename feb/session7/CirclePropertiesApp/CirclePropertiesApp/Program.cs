using CirclePropertiesApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePropertiesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circleA = new Circle(9, "green","line");
            PrintDetails(circleA, "Details of circle A");
            circleA.Color = "red";
            PrintDetails(circleA, "Details of circle A");
        }
        static void PrintDetails(Circle circle, string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine($"radius is {circle._radius}");
            Console.WriteLine($"color is {circle._color}");
            Console.WriteLine($"border is {circle._border}");
            Console.WriteLine($"area is {circle.CalculateArea()}");
            Console.WriteLine();

        }
    }
}
