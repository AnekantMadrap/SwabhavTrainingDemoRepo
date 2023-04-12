using StructClassDiffApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructVsClassApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            PointClass point1 = new PointClass(50, 50);
            Console.WriteLine("Before Modification : ");
            point1.ShowPoint();
            ModifyStructValues(point1);
            Console.WriteLine("After Modification : ");
            point1.ShowPoint();
        }

        private static void CaseStudy1()
        {
            PointClass point2 = new PointClass(10, 20);
            Console.WriteLine("Before Modification : ");
            point2.ShowPoint();
            ModifyClassValues(point2);
            Console.WriteLine("After Modification : ");
            point2.ShowPoint();
        }

        private static void ModifyStructValues(PointClass point)
        {
            point.GetX += 100;
            point.GetY += 100;
        }
        private static void ModifyClassValues(PointClass point)
        {
            point.GetX += 100;
            point.GetY += 100;
        }
    }
}

