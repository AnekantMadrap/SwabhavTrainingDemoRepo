using AccountPolymorphismApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
            CaseStudy4();
            
        }

        private static void CaseStudy4()
        {
            CurrentAccount accountA = new CurrentAccount(202, "zxc", 3000);
            accountA.Withdraw(9000);
            PrintDetail(accountA, "withdraw ammount in account A");
        }

        private static void CaseStudy3()
        {
            SavingAccount account1 = new SavingAccount(102, "bvc", 2500);
            account1.Withdraw(2000);
            PrintDetail(account1, "withdraw ammount in account 1");
        }

        private static void CaseStudy2()
        {
            CurrentAccount accountA = new CurrentAccount(201, "xyz", 2000);
            accountA.Deposite(2500);
            PrintDetail(accountA, "deposite ammount of account A");
        }

        private static void CaseStudy1()
        {
            SavingAccount account1 = new SavingAccount(101, "avc", 1500);
            account1.Deposite(2000);
            PrintDetail(account1, "deposite ammount in account 1"); ;
        }

        static void PrintDetail(Account account,string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine("account number is : {0}",account.Accno);
            Console.WriteLine("account name is : {0}",account.Name);
            Console.WriteLine("account balance is : {0}", account.Balance);
            Console.WriteLine();

        }
    }
}
