using StudentPropertyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPropertyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fee s1 = new Fee();
            s1.PayFee(20000);
            s1.PayFee(30000);
        }

    }
}
