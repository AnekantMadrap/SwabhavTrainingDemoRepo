using RectangleEncapsulation.Model;
using RectangleEnumApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEnumApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangleA = new Rectangle(100, 50,ColorOption.GREEN);
            PrintDetails(rectangleA, "Details of rectangle A");
            Rectangle rectangleB = new Rectangle(30, 15, ColorOption.RED,BorderOption.DOTTED);
            PrintDetails(rectangleB, "Details of rectangle B");
        }
        static void PrintDetails(Rectangle rectangle, string v)
        {
            Console.WriteLine(v.ToUpper());
            Console.WriteLine($"width is {rectangle.Width}");
            Console.WriteLine($"height is {rectangle.Height}");
            Console.WriteLine($"color is {rectangle.Color}");
            Console.WriteLine($"border is {rectangle.Border}");
            Console.WriteLine();

        }
    }
}
