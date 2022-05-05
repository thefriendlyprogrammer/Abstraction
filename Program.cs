using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    //abstract class have both methods abstract method and non abstract method
    abstract class test
    {
        public abstract void show();              // this is abstrac method which does nat have body
        public abstract void showp();

        public void show1()                         // this is non abstract method 
        {
            Console.WriteLine("this is show1");
        }

    }
    abstract class test1:test                      // abstract class test is inherited in abstract class test1
    {
        public abstract void shows();              // abstract method 
        public abstract void showps();             // abstract method 

        public void shows1()                       // this is non abstract method
        {
            Console.WriteLine("this is show second "); 
        }

    }

    class Program : test1                           // child class program inherite proterty of parent class test1 
    {
        public override void show()                 // override keyword must write in abstract 
        {
            Console.WriteLine("this is abstract body");
        }
        public override void showp()
        {
            Console.WriteLine("this is abstract pbody");
        }
        public override void showps()
        {
            Console.WriteLine("this is method of second abstrac class");
        }
        public override void shows()
        {
            Console.WriteLine("this is method of second abstrac class");
        }




        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.show1();
            obj.showp();
            test obj1;
            obj1 = obj;
            obj1.show();
            obj1.show1();
            obj.showps();
            obj.shows();
            Console.ReadLine();
        }
    }
}
