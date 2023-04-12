using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Casestudy1();
            Casestudy2();
            Casestudy3();
            Casestudy4();
          
        }

        private static void Casestudy4()
        {
            Account AccountB = new Account(102, "Anekant", 600);
            PrintDetails(AccountB, "detail of Account B");
        }

        private static void Casestudy3()
        {
            Account AccountA = new Account(101, "Anekant");
            AccountA.Withdraw(500);
            PrintDetails(AccountA, "detail of Account A");
        }

        private static void Casestudy2()
        {
            Account AccountA = new Account(101, "Anekant");
            AccountA.Deposite(500);
            PrintDetails(AccountA, "detail of Account A");
        }

        private static void Casestudy1()
        {
            Account AccountA = new Account(101, "Anekant");
            PrintDetails(AccountA, "detail of Account A");
        }

        static void PrintDetails(Account account,string description)
        {
            Console.WriteLine("name: " + account.Name);
            Console.WriteLine("balance: " + account.Balance);
            Console.WriteLine("accountno: " + account.Accno);
            Console.WriteLine();
        }
    }
}
