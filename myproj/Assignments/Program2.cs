using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dummy
{
    class Program2
    {
        static void Main(string[] args)
        {

            /* String string1 = "Learning C# is a great fun";
             String substring = "great";*/
            Console.WriteLine("Enter string");
            String string1 = Console.ReadLine().Trim();
            Console.WriteLine("Enter substring");
            String substring = Console.ReadLine().Trim();
            int substring_length = substring.Length;
            StringBuilder part1 = new StringBuilder();
            StringBuilder part2 = new StringBuilder();
            int ind = string1.IndexOf(substring);
            if (ind >= 0)
            {

                for (int i = 0; i < ind; i++)
                {
                    part1.Append(string1[i]);
                }
                String spart1 = part1.ToString().Trim();
                for (int i = ind + substring_length; i < string1.Length; i++)
                {
                    part2.Append(string1[i]);
                }
                String spart2 = part2.ToString().Trim();
                Console.WriteLine(spart1 + " " + spart2);
            }
            else {
                Console.WriteLine("Oops!! try with other substring ..");
            }
        }
    }
}
