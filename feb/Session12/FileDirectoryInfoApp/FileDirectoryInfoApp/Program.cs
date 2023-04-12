using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDirectoryInfoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            CaseStudy3();
        }

        private static void CaseStudy3()
        {
            string path = @"E:\swabha\Session12\file1\file";
            FileInfo file1= new FileInfo(path);
            string filename = file1.Name;
            Console.WriteLine("File Name: {0}", filename);
            string fullname = file1.FullName;
            Console.WriteLine(fullname);
            string directoryname = file1.DirectoryName;
            Console.WriteLine(directoryname);
            string path1= @"E:\swabha\Session12\file1\file1.txt";
            FileInfo file2 = new FileInfo(path1);
            /*file2.Create();
            {
                Console.WriteLine("file 2 created");
            }*/
            file2.Delete();
            {
                Console.WriteLine("file 2 is delete");
            }
        }

        private static void CaseStudy2()
        {
            string path2 = @"E:\swabha\Session12\Directory1\Directory2";
            DirectoryInfo directoryB = new DirectoryInfo(path2);
            directoryB.Delete();
            {
                Console.WriteLine("delete Directory ");
            }
            
            Console.ReadKey();
        }

        private static void CaseStudy1()
        {
            string path = @"E:\swabha\Session12\Directory1";
            DirectoryInfo directoryA = new DirectoryInfo(path);
            DirectoryInfo directoryB = directoryA.CreateSubdirectory("Directory2");
            //directoryA.Create();
            {
                //Console.WriteLine("we create directory A");
                Console.WriteLine("SubDirectory has been created");
            }
            Console.ReadKey();
        }
    }
}
