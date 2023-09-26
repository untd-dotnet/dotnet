using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace myproj.Practise
{
    class ExecpnHand
    {
        static void Main() {
            StreamReader streamReader = null;
            try
            {
                //streamReader = new StreamReader(@"C:\Users\nsreevani\Desktop\training\test.txt");
                //streamReader = new StreamReader(@"C:\Users\nsreevani\Desktop\training\test1.txt");
                streamReader = new StreamReader(@"C:\Users\nsreevani\Desktop\training1\test.txt");
                Console.WriteLine(streamReader.ReadToEnd());
            }
            catch (FileNotFoundException fex)
            {
                Console.WriteLine(fex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oops!!Exeception it is , Could you pls check the resource ? Below is the stacktrace : \n");
                Console.WriteLine(ex.StackTrace);
            }
            finally {
                streamReader.Close();
            }
            
            
        }
    }
}
