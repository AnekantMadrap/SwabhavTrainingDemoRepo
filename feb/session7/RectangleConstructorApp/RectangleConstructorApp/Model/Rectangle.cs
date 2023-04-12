using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulation.Model
{
    internal class Rectangle
    {
        private readonly int _width;
        private readonly int _height;
        private string _color;

        public Rectangle(int width, int height,string color)
        {
            _width = ValidateSide(width);
            _height = ValidateSide(height);
            _color = Validatecolor(color);
        }

        private int ValidateSide(int z)
        {
            if (z > 100)
            {
                return 100;
            }
            else if (z < 0)
            {
                return 1;
            }
            else
            {
                return z;
            }
        }

        private string Validatecolor(string pcolor)
        {
            string acolor = pcolor.ToLower();
            if (acolor == "red" || acolor == "blue" || acolor == "green")
            {
                return acolor;
            }
            else
            {
                return "red";
            }
        }
        public int CalculateArea()
        {
            int area = _width * _height;
            return area;
        }
        public int GetWidth() 
        {
            return _width;
        }
        

        public int GetHeight()
        {
            return _height;
        }

        

        public string GetColor()
        {
            return _color;
        }
        
        public void SetColor(string color)
        {
            _color = Validatecolor(color);
        }
    }
}
