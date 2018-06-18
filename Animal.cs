using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_demo
{
    //*1*
    public abstract class Animal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime birthday { get; set; }


        public string derink()
        {
            return Name + "is drinking Water  ";
        }
        public abstract string Eat();//Abstract Class ,(No Body)
        
    }
    public class Bird:Animal
    {
        public override string Eat()//Abstract Class *
        {
            return Name + "is Eating 7bob ";  //<--(Body)
        }
    }
    public class Lion : Animal
    {
        public override string Eat()
        {
            return Name + "is Eating la7ma ";  //<--(Body)
        }
    }
}
