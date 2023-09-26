using System;

namespace myproj.Practise {
    class Student2
    {
        private int rollno;
        private string name;
        private double percentage;

        public delegate String getGradeClass(Student2 s);

        Student2(int rollno, String name, double percentage)
        {
            this.Rollno = rollno;
            this.Name = name;
            this.Percentage = percentage;
        }

        public int Rollno { get => rollno; set => rollno = value; }
        public string Name { get => name; set => name = value; }
        public double Percentage { get => percentage; set => percentage = value; }



        public static String getClass(Student2 s, getGradeClass storegrade)
        {
            return storegrade(s);
        }
        
        public static void main()
        {
            Student2 s1 = new Student2(1, "vani", 98.7);
            Student2 s2 = new Student2(2, "ram", 94.7);
            Student2 s3 = new Student2(3, "sagari", 99.7);
            /*getGradeClass storegrade = delegate(Student2 s) {
                if (s.percentage > 98.00)
                {
                    return "First";
                }
                else
                {
                    return "Second";
                }
            };*/
            getGradeClass storegrade = s =>
            {
                if (s.percentage > 98.00)
                {
                    return "First";
                }
                else
                {
                    return "Second";
                }
            };
            //String grade = ggc(s1);
            String grade = getClass(s1, storegrade);
            Console.WriteLine(grade);
        }

    }
}

