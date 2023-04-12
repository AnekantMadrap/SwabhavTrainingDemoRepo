using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeToStringEqualApp.Model
{
    internal class Employee
    {
        private int _id;
        private string _name;
        private double _salary;

        public Employee(int id,string name,int salary)
        {
            _id= id;
            _name = name;
            _salary=salary;
        }

        public override string ToString()
        {
            string template = "";
            template += "id:" + _id;
            template += "\nname: " + _name;
            template += "\nsalary" + _salary;
            template += base.ToString();
            return template;
        }
        public override bool Equals(object box)
        {
            Employee other = (Employee)box;
            if (this.Id == other.Id)
                return true;
            return false;
        }
        public int Id
        {
            get { return _id; } 
        }
        public string Name
        {
            get { return _name; }
        }
        public double Salary
        {
            get { return _salary; }
        }
    }
}
