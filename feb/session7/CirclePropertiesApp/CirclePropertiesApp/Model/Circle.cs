using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePropertiesApp.Model
{
    internal class Circle
    {
        private readonly int _radius;
        private string _color;
        private string _border;

        public Circle(int radius,string color,string border) 
        { 
            _radius = Validationside(radius);
            _color = Validationcolor(color);
            _border = ValidationBorder(border);
        }
        private int Validationside(int side)
        {
            if (side > 10)
            {
                return 10;
            }
            else if (side < 0)
            {
                return 1;
            }
            else
            {
                return side;
            }
        }
        private string Validationcolor(string color)
        {
            string acolor = color.ToLower();
            if (acolor == "red" || acolor == "blue" || acolor == "green")
            {
                return acolor;
            }
            else
            {
                return "red";
            }
        }
        private string ValidationBorder(string border)
        {
            if (border == "line" || border == "dotted" || border == "double")
            {
                return border;
            }
            else
            {
                return "line";
            }
        }
        public int CalculateArea()
        {
            int area = _radius * _radius;
            return area;
        }
        public int Radius 
        {
            get { return _radius; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = Validationcolor(value); }
        }
        public string Border
        {
            get { return _border; }
        }
    }
}
