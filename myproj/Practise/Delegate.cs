using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproj.Practise
{
    public delegate void Sample_delegate(int somthing);
    /*class Delegate
    {

        public static void somefunc(int marks)
        {
            Console.WriteLine("Marks : " + marks);
        }

        static void main() {
            Console.WriteLine("Testing delegate");
            Sample_delegate del = new Sample_delegate(somefunc);
            del(54);
        }
    }*/

    class Anony_Delegate
    {
        static void main()
        {
            Console.WriteLine("Testing delegate");
            Sample_delegate del = delegate (int marks)
            {
                Console.WriteLine("Marks : " + marks);
            };
            del(54);

        }
    }
}
