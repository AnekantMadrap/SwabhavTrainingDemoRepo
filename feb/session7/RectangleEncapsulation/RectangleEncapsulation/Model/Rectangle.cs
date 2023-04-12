using System;
using System.Collections.Generic;
using System.Linq;using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulation.Model
{
    internal class Rectangle
    {
        private int _width;
        private int _height;
        private string _color;

        private int Same(int z)
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
        public void SetWidth(int pwidth)
        {
            _width = Same(pwidth);

            /*if(pwidth > 100)
            {
                _width = 100;
            }
            else if(pwidth < 0) 
            {
                _width = 1;
            }
            else
            {
                _width = pwidth;
            }*/
        }
        
        public int GetWidth() 
        {
            return _width;
        }
        public void SetHeight(int pheight)
        {
            _height = Same(pheight);
            /*if (pheight > 100)
            {
                _height = 100;
            }
            else if (pheight < 0)
            {
                _height = 1;
            }
            else
            {
                _height = pheight;
            }*/
        }

        public int GetHeight()
        {
            return _height;
        }

        public void SetColor(string pcolor)
        {
            string acolor = pcolor.ToLower();
            if(acolor == "red" || acolor == "blue" || acolor == "green")
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
        public int CalculateArea()
        { 
            int area = _width * _height;
            return area; 
        }
    }
}
