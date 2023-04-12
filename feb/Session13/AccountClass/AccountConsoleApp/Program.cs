using AccountClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(101, "anuj", 2000);
            PrintDetails(account);
            account.Deposite(1000);
            PrintDetails(account);
            account.Withdraw(1500);
            PrintDetails(account);
        }

        private static void PrintDetails(Account account)
        {
            Console.WriteLine("account number is : "+account.Accountno);
            Console.WriteLine("account name : "+account.Name);
            Console.WriteLine("account balance : "+account.Balance);
            Console.WriteLine();
        }
    }
}
