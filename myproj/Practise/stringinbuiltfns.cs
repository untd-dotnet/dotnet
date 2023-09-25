using System;
namespace Practiseproj
{ 
class Smthng
    {
        static void main()
        {
            String str = "Vani";
            Console.WriteLine("Pad left : {0}\n",str.PadLeft(10,'.'));
            Console.WriteLine("Pad right : {0}\n", str.PadRight(10, '.')); 
            Console.WriteLine("trim : {0}\n", str.Trim());
            Console.WriteLine("To lower case : {0}\n", str.ToLower());
            Console.WriteLine("To upper case : {0}\n", str.ToUpper());
            String egformat = String.Format("{0} lived in a {1}","Sheela","Mansion");
            Console.WriteLine(egformat + "\n");
            Console.WriteLine("\"Vani\"");
            Console.WriteLine("Path : C:\\Desktop");
            Console.WriteLine(@"Vani\n");
            Console.WriteLine(@"Path : C:\\Desktop");
            Console.WriteLine("\nLETS DIVE INTO ARRAYS ..");
            int[] intArray = new int[3];
            intArray[1] = 2;
            String[] strArray = new String[3];
            var newArray = new[] { "hi", "helo" };
            Object[] objArray = {"vani", "16","100.00"};
            for (int i = 0; i < objArray.Length; i++)
            {
                Console.WriteLine("Index : {0} , Value : {1}", i, objArray[i]);
            }
            






        }
    }
}