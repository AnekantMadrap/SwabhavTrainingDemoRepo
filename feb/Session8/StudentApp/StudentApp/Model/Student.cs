using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Model
{
    internal class Student
    {
        private int _rollno;
        private string _name;
        private double _cgpa;
        private readonly double cgpa1 = 9.5;

        public Student(int rollno, string name,double cgpa)
        {
            _rollno = ValidationRollno(rollno);
            _name = ValidationName(name);
            _cgpa = ValidationCgpa(cgpa);

        }

        private double ValidationCgpa(double cgpa)
        {
            if (cgpa >= 1 && cgpa <= 10)
            {
                return cgpa;
            }
        }

        private string ValidationName(string name)
        {
            if (name.Length <= 5)
            {
                //Console.WriteLine("");
                return string.Empty;
            }
            else
            {
                return name;
            }
        }

        private int ValidationRollno(int rollno)
        {
            if (rollno <= 0)
            {
                return 0;
            }
            else
            {
                return rollno;
            }
        }

        public double Cgpa
        {
            get
            {
                return _cgpa;
            }
            
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int Rollno
        {
            get { return _rollno; }
        }
        public double Percentage()
        {
            return cgpa1 * _cgpa;
        }
        /*public int GetRollno()
        {
            return _rollno; 
        }
        public string GetName()
        {
            return _name;
        }
        public double GetCgpa()
        {
            return _cgpa; 
        }*/

    }

}
