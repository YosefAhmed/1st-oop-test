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
        //Encapsulation 
        //1
        private decimal _salary;
        //2
        public decimal Salary 
        {
            //3
            get { return _salary; }
            //4
            set
            {
                if(value>=700)
                {
                     _salary=value;
                 }
                else
                {
                    throw new Exception("Salary must be at least 700& !");
                }
            }


        }
        //methods
        public String Report()
        {
            return "ID :" + ID + "\nName :" + Name +
                "\nCity :" + City + "\nSalary :" + Salary;
        }
        
        
        }
    class Managr : Employee  //Inheritance 
        {
            public static int bones { get; set; }  //static field
            public String Reportmanagr()
        {
            return  base.Report()+"\nbones :"+bones;
        }
        }
    }

