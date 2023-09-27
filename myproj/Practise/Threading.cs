using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace myproj.Practise
{
    /*class Threading
    {

        static void method1() {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("Hi ");
                
            }
        }
        static void Main() {
            Thread t1 = new Thread(method1);
            t1.Start();
            for (int i = 0; i < 100; i++)
            {
                Console.Write("Hello ");
            }

        }
    }*/

    class Threading
    {
        static void main()
        {

            for (int i = 0; i < 100; i++)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
            }

        }
    }







}
