using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_demo
{
    class Employee
    {
        //properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public decimal Salary { get; set; }
        //methods
        public String Report()
        {
            return "ID :" + ID + "\nName :" + Name + "\nCity :" + City + "\nSalary :" + Salary;
        }
        //events
    }
}
