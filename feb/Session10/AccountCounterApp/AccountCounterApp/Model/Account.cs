using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AccountCounterApp.Model
{
    internal class Account
    {
        private readonly int _accno;
        private readonly string _name;
        private double _balance;
        private const double MinBalance=500;
        private static int _instanceCount = 0;

        public Account(int accno, string name, double balance)
        {
            _accno = accno;
            _name = name;
            _balance = balance;
            _instanceCount += 1;
        }

        public Account(int accno,string name):this(accno,name,MinBalance)
        {
         
        }

        public void Deposite(double amount) {
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            //double AmountAfterWithdraw = _balance - amount;
            if(SufficientFundAvaliable(amount)) 
            {
                _balance -= amount;        
            }
            else
            {
                Console.WriteLine("error,no fund");
            }
        }
        private bool SufficientFundAvaliable(double withamount)
        {
            double AmountAfterWithdraw = _balance - withamount;
            return AmountAfterWithdraw >= MinBalance;
        }
        public double Balance
        {
            get { return _balance; }
        }
        public string Name
        {
            get { return _name; }
        }
        public double Accno
        {
            get { return _accno; }
        }
        public int InstanceCount
        {
            get
            {
                return _instanceCount;
            }
        }
        public static int HeadCount()
        {
            return _instanceCount;
        }
    }
} 
