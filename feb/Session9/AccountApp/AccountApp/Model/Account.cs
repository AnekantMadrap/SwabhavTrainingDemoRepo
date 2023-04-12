using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Model
{
    internal class Account
    {
        private int accountno;
        private string name;
        private int balance;
        public int maxname;

        public Account(int accountno, string name, int balance)
        {
            this.accountno = accountno;
            this.name = name;
            this.balance = balance;
        }
        public Account FindRichest(Account[] manyaccount)
        {
            Account max = manyaccount[0];
            foreach (Account account in manyaccount)
            {
                if (max.balance < account.balance)
                {
                    max = account;
                }
            }

            return max;
        }
        public Account[] FindLongName(Account[] manyaccount)
        {
            int count = 0;
            for (int i = 0; i < manyaccount.Length; i++)
            {
                if (manyaccount[i].name.Length > 5)
                {
                    count++;
                }
            }
            Account[] longname = new Account[count];
            int k = 0;
            for (int j = 0; j < manyaccount.Length; j++)
            {
                if (manyaccount[j].name.Length > 5)
                {
                    longname[k] = manyaccount[j];
                    k++;
                }
            }
            return longname;

        }
        public int Accountno
        {
            get
            { return accountno; }
        }
        public string Name
        {
            get
            { return name; }
        }
        public double Balance
        {
            get
            { return balance; }
        }
        /*public Account FindRich(Account[] manyaccount)
        {
            Account rich = manyaccount[0];
            foreach (Account account in manyaccount)
            {
                if (rich.balance > account.balance)
                {
                    rich=rich;
                }
                else
                {
                    rich=account;
                }
            }
            return rich;
        }*/
        /*public Account FindLongName(Account[] manyaccount)
        {
            int count = 0;
            //Account[] longname = new Account[count];
            foreach (Account account in manyaccount)
            {
                if (account.name.Length > 5)
                {
                    //longname.Append(account);
                    count++;
                }
            }
            for(int i=0;i<count;i++)
            {
                Account[] longname = new Account[count];
                if (manyaccount[i].name.Length > 5)
                {
                    return manyaccount[i];
                    //count++;
                }
            }
            return null;
        }*/



    }
}
