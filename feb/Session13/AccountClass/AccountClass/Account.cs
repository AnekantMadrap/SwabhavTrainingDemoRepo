using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClass
{
    public class Account
    {
        private readonly int _accountno;
        private readonly string _name;
        private double _balance;

        public Account(int accountno, string name, double balance)
        {
            _accountno = accountno;
            _name = name;
            _balance = balance;
        }
        public void Deposite(double ammount)
        {
            _balance += ammount;
        }
        public void Withdraw(double ammount)
        {
            if(_balance - ammount >= 1000)
            {
                _balance -= ammount;
            }
            else { Console.WriteLine("error,no fund"); }
            
        }
        public int Accountno { get { return _accountno;} }
        public string Name { get { return _name;} } 
        
        public double Balance { get { return _balance;} }
    }
}
