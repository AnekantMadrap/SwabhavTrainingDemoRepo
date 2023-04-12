using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    internal class SavingAccount : Account
    {
        private const int Min_Balance = 1000;
        public SavingAccount(int accno, string name, double balance) : base(accno, name, balance)
        {
        }

        public override void Withdraw(double amount)
        {
            if (_balance - amount > Min_Balance)
            {
                _balance = _balance - amount;
                return;
            }
            throw new Exception("no sufficent fund");
        }
    }
}
