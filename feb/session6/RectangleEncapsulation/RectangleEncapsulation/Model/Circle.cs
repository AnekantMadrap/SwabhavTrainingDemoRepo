using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulation.Model
{
    internal class Circle
    {
        private int _radius;
        private string _color;
        private string _border;

        public void SetRadius(int pradius)
        {
            if(pradius > 10)
            {
                _radius = 10;
            }
            else if(pradius< 1)
            {
                _radius = 1;
            }
            else
            {
                _radius = pradius;
            }
        }

        public int GetRadius() 
        { 
            return _radius;
        }

        public void SetColor(string pcolor)
        {
            string acolor = pcolor.ToLower();
            if (acolor == "red" || acolor == "blue" || acolor == "green")
            {
                _color = pcolor;
            }
            else
            {
                _color = "red";
            }
        }

        public string GetColor()
        {
            return _color;
        }

        public void SetBorder(string pborder)
        {
            if (pborder == "dotted" || pborder == "double" || pborder == "solid")
            {
                _border = pborder;
            }
            else
            {
                _border = "solid";
            }
        }

        public string GetBorder()
        {
            return _border;
        }

        public double CalculateArea()
        {
            double area =3.14 * _radius * _radius;
            return area;
        }
    }
}
