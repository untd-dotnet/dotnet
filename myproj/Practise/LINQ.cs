using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproj.Practise
{
    class LINQ
    {
        static void main() {
            String[] names = { "SreeVani", "Vani Sagari", "Sailesh", "John Smith" };
            var nameswithspaces = from name in names where name.Contains(" ") select name;
            foreach (var name in nameswithspaces) {
                Console.WriteLine(name);
            }
            int[] digits = { 2, 3, 4, 7, 5, 6 };
            int[] intgreater = getintgreater(digits);
            foreach (int i in intgreater)
            {
                Console.WriteLine(i);
            }


        }
        static int[] getintgreater(int[] digits) {
            var intgreater = from digit in digits where digit > 3 orderby digit descending select digit;
            return intgreater.ToArray();
            
        }
    }
}
