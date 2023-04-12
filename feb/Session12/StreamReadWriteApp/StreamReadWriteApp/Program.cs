using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReadWriteApp
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
            string path = @"E:\swabha\Session12\file1\file2.txt";
            using(StreamWriter write1=new StreamWriter(path))
            {
                write1.WriteLine("welcome to new file");
                write1.WriteLine("hello");
                
            }
        }

        private static void CaseStudy1()
        {
            string path = @"E:\swabha\Session12\file1\file2.txt";
            using(StreamReader read1 = new StreamReader(path))
            {
                Console.WriteLine(read1.ReadToEnd());
            }
        }
    }
}
