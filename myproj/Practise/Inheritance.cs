using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiseproj
{
    public class Parent
    {
         public String parentprop = "fixed";
        public Parent() {
            Console.WriteLine("simulating inheritance. Parent class constructor called");
        }
        public Parent(String msg) {
            Console.WriteLine("Constructor with msg called : " + msg );
        }
        
    }
    public class Childclass : Parent
    {
        public Childclass() : base ("controlling parent class constructor")
        {
            Console.WriteLine("In Childclass class constructor");
        }


    }
    public class Inheritance {

        static void main() {
            Childclass cc = new Childclass();
            Childclass cc1 = new Childclass();
            Console.WriteLine(cc.parentprop);
        }
    }
}
