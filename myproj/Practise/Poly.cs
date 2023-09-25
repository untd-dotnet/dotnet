using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiseproj
{   
    class Student {
        String firstname;
        String lastname;
        public Student() {  
          firstname = "first" ;
          lastname = "last";
        }

        public void getfullname() {
            Console.WriteLine(this.firstname + this.lastname);
        }

        public void getfullname(String msg) {
            Console.WriteLine(this.firstname + this.lastname + msg);
        }

        public void getfullname(int code,String msg) {
            Console.WriteLine(this.firstname + this.lastname + msg + code);
        }

        public void getfullname(String msg, int code)
        {
            Console.WriteLine(this.firstname + this.lastname + msg + code);
        }
        /* public String getfullname() { 
             return firstname+lastname;
         }
        */

        public void calcpercentage(double cgpa) {
                Console.WriteLine(cgpa * 10.0);
         }

         public virtual String getpassfail(char grade){ 
            if(grade == 'F') { 
                return "fail";
            }
            return  "pass";
         }
    }
    class Topper : Student {
        public Topper() { 
            
        }
        public new void calcpercentage(double cgpa) {
            Console.WriteLine(cgpa * 0.9);
            /*base.calcpercentage(cgpa);*/
        }
        
         public override String getpassfail(char grade){ 
          return "pass";
         }
    }
    class Poly{
        static void main()
        {
            Student s1 = new Student();
            Student s2= new Topper();
            Topper t = new Topper();
            double cgpa = 8.97;
            s1.calcpercentage(cgpa);
            s2.calcpercentage(cgpa);
            t.calcpercentage(cgpa);
            ((Student)t).calcpercentage(cgpa);
            String pf = t.getpassfail('F');
            Console.WriteLine(pf);
            s1.getfullname();
            s1.getfullname("Hi");
            s1.getfullname(1,"Hi");
            s1.getfullname("Hi",1);
            //Console.WriteLine(s1.getfullname());


        }

    }
}

