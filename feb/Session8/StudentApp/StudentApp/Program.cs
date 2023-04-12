using StudentApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1,"Anekant",8.7);
            PrintDetails(student1, "Details of student 1");
        }
        static void PrintDetails(Student student, string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine($"Rollno is {student.Rollno}");
            Console.WriteLine($"Name is {student.Name}");
            Console.WriteLine($"CGPA is {student.Cgpa}");
            Console.WriteLine($"Percentage is {student.Percentage()}");
            Console.WriteLine();

        }
    }
}
