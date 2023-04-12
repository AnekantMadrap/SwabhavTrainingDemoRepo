using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DifferenceApp.Model
{
    internal class Odd
    {
        private const int n=0;
        private int m;
        public readonly int[] _number;

        public Odd(int n, int m)
        {
            int totalodd = (m - n) / 2 + 1;
            _number = new int[totalodd];
            int count = 0;
            for (int i = n; i < m; i++)
            {
                if (i % 2 != 0)
                {
                    _number[count++] = i;
                }
            }
        }
        public Odd(int m) : this(n, m)
        {
            Console.WriteLine();
        }
        public int[] Number
        {
            get { return _number; }
        }
    }
}
