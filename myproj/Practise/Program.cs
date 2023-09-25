using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiseproj
{
    class Program
    {
        static void main(string[] args)
        {
            /*Console.Write("Enter name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Hello {0}! How do you do ?\n", name);
            bool booleanValue = true;
            int intValue = int.Parse("1234");
            long longValue = intValue;
            long longoriginal = 145678L;
           //Console.WriteLine(longoriginal.GetType());
            float floatValue = 34.2F;
            double doubleValue = 35.8D;
            //Console.WriteLine(doubleValue.GetType());
            decimal decimalValue = 24.6M;
            Console.WriteLine($"Exploring $ with float value : {floatValue}\n");
            Console.WriteLine("Do you know the max value in decimal data type?\n{0}\n",Decimal.MaxValue);
            Console.WriteLine("Double value after typecasting to int (Explicit) : {0}\n",(int)doubleValue);
            Console.WriteLine("Int value after typecasting to long (Implicit) : {0}     Type : {1}\n",longValue, longValue.GetType());
            Console.WriteLine("Int value after parsing string is (used concatenation instead of place holder): " +  intValue);
            Console.WriteLine("\nDouble converted to string : \nValue : {0}\nType : {1}\n", doubleValue.ToString(),doubleValue.ToString().GetType());
            Console.WriteLine("Padded with zeroes : {0:d4}", 12);
            //Console.WriteLine(doubleValue.ToString("C3", System.Globalization.CultureInfo.CurrentCulture));
            Console.WriteLine("Rounding off : {0:f3}", 31.267807);
            Console.WriteLine("Lets put commas: {0:n2}", 324869);
            String[] cities = {"Chennai","Mumbai","Delhi","Hyderabad"};
            Console.WriteLine("Tried declaring string : {0}" ,String.Join(",", cities));*/

            String s = "This is a string";
            Console.WriteLine(s.Length);
            Console.WriteLine(s.Contains("a"));
            Console.WriteLine(s.IndexOf("is"));
            Console.WriteLine(s.IndexOf("r"));
            Console.WriteLine(s.Remove(4,3));
            Console.WriteLine(s.Insert(5,"was "));
            Console.WriteLine(s.Replace("string","sentence"));
            Console.WriteLine(String.Compare("Aadhya","Aasin"));
            Console.WriteLine(String.Compare("Aadhya", "AaDHyA",StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(String.Equals("Adhya", "Adithya"));
            Console.WriteLine(String.Equals("Aadhya", "AaDHyA",StringComparison.OrdinalIgnoreCase));

        }
    }
}
