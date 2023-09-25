using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproj.Practise
{
    /* class Student
     {
         private int rollno;
         private string name;
         private double percentage;


         Student(int rollno, String name, double percentage) {
             this.Rollno = rollno;
             this.Name = name;
             this.Percentage = percentage;
         }

         public int Rollno { get => rollno; set => rollno = value; }
         public string Name { get => name; set => name = value; }
         public double Percentage { get => percentage; set => percentage = value; }

         public static String getClass(Student s) {
             if (s.percentage > 98.00) {
                 return  "First";
             }
             else {
                 return "Second";
             }
         }


         public static void Main() {
             Student s1 = new Student(1, "vani", 98.7);
             Student s2 = new Student(2, "ram", 94.7);
             Student s3 = new Student(3, "sagari", 99.7);
             String grade = getClass(s1);
             Console.WriteLine(grade);
         }

     }*/

    class Student
    {
        private int rollno;
        private string name;
        private double percentage;

        public delegate String  getGradeClass(Student s);

        Student(int rollno, String name, double percentage)
        {
            this.Rollno = rollno;
            this.Name = name;
            this.Percentage = percentage;
        }

        public int Rollno { get => rollno; set => rollno = value; }
        public string Name { get => name; set => name = value; }
        public double Percentage { get => percentage; set => percentage = value; }


        
        public static String getClass(Student s,getGradeClass storegrade)
        {
            return storegrade(s);
        }
        public static String newmethod(Student s) {
            if (s.percentage > 98.00)
            {
                return "First";
            }
            else
            {
                return "Second";
            }
        }


        public static void Main()
        {
            Student s1 = new Student(1, "vani", 98.7);
            Student s2 = new Student(2, "ram", 94.7);
            Student s3 = new Student(3, "sagari", 99.7);
            getGradeClass storegrade = new getGradeClass(newmethod);
            //String grade = ggc(s1);
            String grade = getClass(s1,storegrade);
            Console.WriteLine(grade);
        }


    }
}
