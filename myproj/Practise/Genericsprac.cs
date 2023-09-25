using System;
using System.Collections.Generic;

namespace Practiseproj
{
   
    public class Genericsprac
    {

       
        public static void getdetailsofsametype<T>(T fname,T lname)
        {
            Console.WriteLine(fname + " " + lname);
        }

        

    }

    class Driver
    {
        static String fname = "vani";
        static String lname = "sagari";

       /* Driver()
        {
            fname = "vani";
            lname = "sagari";
        }
*/

        public static void main(String[] args)
        {
            Console.WriteLine("HI");
            Genericsprac.getdetailsofsametype<String>(fname, lname);
            Genericsprac.getdetailsofsametype<int>(1, 2);
        }


    }
}
