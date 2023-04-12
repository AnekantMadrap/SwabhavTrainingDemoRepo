using AccountCounterApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCounterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            Account acc1 = new Account(101, "a", 50);
            Console.WriteLine(Account.HeadCount());
            Account acc2 = new Account(102, "b", 50);
            Console.WriteLine(Account.HeadCount());
            Account acc3 = new Account(103, "c", 50);
            Console.WriteLine(Account.HeadCount());
        }

        private static void CaseStudy1()
        {
            Account acc1 = new Account(101, "a", 50);
            Console.WriteLine(acc1.InstanceCount);
            Account acc2 = new Account(102, "b", 50);
            Console.WriteLine(acc2.InstanceCount);
            Account acc3 = new Account(103, "c", 50);
            Console.WriteLine(acc3.InstanceCount);
        }
    }
}
