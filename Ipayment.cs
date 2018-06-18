using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_demo
{
    interface Ipayment
    {
        String pay(int amount);
        int calc(int n1, int n2);
    }
    public class ATM : Ipayment
    {
        public String pay(int amount)
        {
            return "pay done succesfuly!";
        }
       public int calc(int n1, int n2)
        {
            return n1 + n2;
         }

    }
}
