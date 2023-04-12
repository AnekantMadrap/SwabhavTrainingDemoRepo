using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Model
{
    internal class Customer
    {
        private int _id;
        private readonly string _name;
        private readonly int _ordercount;
        private static int _nextid;

        static Customer()
        {
            _nextid = 1000;
        }
        
        public Customer( string name, int ordercount)
        {
            _name= name;
            _ordercount= ordercount;
            _nextid += 1;
            _id =-_nextid;

        }

        
        public string Name
        {
            get { return _name; }
        }
        public int Id
        {
            get { return _id; }
        }
        public int OrderCount
        {
            get
            {
                return _ordercount;
            }
        }
        
    }
} 
