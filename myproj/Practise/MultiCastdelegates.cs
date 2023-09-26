using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproj.Practise
{
    public delegate int Sampledelegate(int marks);

    class MultiCastdelegates
    {
        public static int method1(int marks)
        {
            return marks;
        }

        public static int method2(int marks)
        {
            return marks;
        }
        public static int method3(int marks)
        {
            return 82;
        }

        static void Main()
        {
            Console.WriteLine("Testing delegate");
            /*Sampledelegate del1,del2,del3,del4;
            del1 = new Sampledelegate(method1);
            del2 = new Sampledelegate(method2);
            del3 = new Sampledelegate(method3);
            del4 = del1 + del2 + del3;
            Console.WriteLine(del4(54));*/
            Sampledelegate del = new Sampledelegate(method1);
            del += method2;
            del += method3;
            Console.WriteLine(del(54));


        }
    }
}
