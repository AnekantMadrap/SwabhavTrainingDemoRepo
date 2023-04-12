using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceApp.Model
{
    internal class Even
    {
        private const int n = 0;
        private int m;
        public readonly int[] _number;

        public Even(int n, int m)
        {
            int totalEven = (m - n) / 2 + 1;
            _number = new int[totalEven];
            int count = 0;
            for (int i = n; i < m; i++)
            {
                if (i % 2 == 0)
                {
                    _number[count++] = i;
                }
            }
        }
        public Even(int m) : this(n, m)
        {
            Console.WriteLine();
        }
        public int[] Number
        {
            get { return _number; }
        }

    }
}
