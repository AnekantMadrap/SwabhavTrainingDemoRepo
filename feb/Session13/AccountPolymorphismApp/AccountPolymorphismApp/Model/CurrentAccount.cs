using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    internal class CurrentAccount : Account
    {
        private const int Over_draft_Limit = -5000;
        public CurrentAccount(int accno, string name, double balance) : base(accno, name, balance)
        {
        }

        public override void Withdraw(double amount)
        {
            if(_balance-amount >= Over_draft_Limit)
            {
                _balance=_balance-amount;
                return;
            }
            throw new Exception("over draft ");
        }
    }
}
