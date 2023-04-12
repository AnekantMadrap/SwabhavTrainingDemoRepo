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
            //CaseStudy1();
            CaseStudy2();
            CaseStudy3();

            /*Account minrich = manyaccount[0];
            Account rich = minrich.FindRich(manyaccount);
            PrintDetails(rich, "rich");

            Account[] name1 = new Account[5];
            Account[] LongName = name1.FindLongName(manyaccount);
            for(int i=0;i<manyaccount.Length;i++)
            {
                PrintDetails(LongName[i], "");
            }*/

        }

        private static void CaseStudy3()
        {
            Account[] manyaccount = new Account[5];
            manyaccount[0] = new Account(11, "rohan", 12000);
            manyaccount[1] = new Account(12, "amar", 23000);
            manyaccount[2] = new Account(13, "shivam", 34000);
            manyaccount[3] = new Account(14, "chirag", 45000);
            manyaccount[4] = new Account(15, "varun", 56000);
            Account longname = new Account(0, "", 0);
            Account[] longarray = longname.FindLongName(manyaccount);
            foreach (Account account in longarray)
            {
                PrintDetails(account, "Long name");
            }
            Console.WriteLine();
         
        }

        private static void CaseStudy2()
        {
            Account[] manyaccount = new Account[5];
            manyaccount[0] = new Account(11, "rohan", 12000);
            manyaccount[1] = new Account(12, "amar", 23000);
            manyaccount[2] = new Account(13, "shivam", 34000);
            manyaccount[3] = new Account(14, "chirag", 45000);
            manyaccount[4] = new Account(15, "varun", 56000);
            Account rich = new Account(0,"",0);
            foreach(Account account in manyaccount)
            {
                rich=account.FindRichest(manyaccount);
            }
            PrintDetails(rich, "rich person is: ");
            Console.WriteLine();
        }

        private static void CaseStudy1()
        {
            Account[] manyaccount = new Account[5];
            manyaccount[0] = new Account(11, "rohan", 12000);
            manyaccount[1] = new Account(12, "amar", 23000);
            manyaccount[2] = new Account(13, "shivam", 34000);
            manyaccount[3] = new Account(14, "chirag", 45000);
            manyaccount[4] = new Account(15, "varun", 56000);
            foreach (Account account in manyaccount)
            {
                PrintDetails(account, "");
            }
        }

        static void PrintDetails(Account account,string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine("Account no:" +account.Accountno);
            Console.WriteLine("name:"+account.Name);
            Console.WriteLine("balance:"+account.Balance);
        }
    }
}
