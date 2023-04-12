using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    internal abstract class Employee
    {
        private int _id;
        private string _name;
        protected double _basicaslary;
        
        public Employee(int id, string name, double basicaslary)
        {
            _id = id;
            _name = name;   
            _basicaslary = basicaslary;
        }

        public  void CalculateAnnualSalary(double ammount)
        {
            _basicaslary += ammount;
        }
        public int Id { get { return _id;} }
        public string Name { get { return _name;} }
        public double Salary
        {
            get { return _basicaslary; }
        }
    }
}
