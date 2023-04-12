using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPropertyApp.Model
{
    internal class Fee
    {
        private static int Totalfee;
        private static int remainfee;
        //private int Payfee;

        static Fee()
        {
            Totalfee = 100000;
        }
     
        public void PayFee(int ammount)
        {
            remainfee = Totalfee - ammount;
            Console.WriteLine($"remaining fee is :{remainfee}");
            Totalfee = remainfee;
            
        }
        
    }
}
