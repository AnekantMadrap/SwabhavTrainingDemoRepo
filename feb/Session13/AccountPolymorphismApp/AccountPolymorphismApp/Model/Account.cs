using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    internal abstract class Account
    {
        private readonly int _accno;
        private readonly string _name;
        protected double _balance;
        //private const double MinBalance=500;

        public Account(int accno, string name, double balance)
        {
            _accno = accno;
            _name = name;
            _balance = balance;
        }

        public void Deposite(double amount) {
            _balance += amount;
        }

        public abstract void Withdraw(double amount);
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
    }
} 
