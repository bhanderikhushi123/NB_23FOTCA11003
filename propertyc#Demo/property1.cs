using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB_23FOTCA11003.propertyc_Demo
{
    internal class property1
    {
        public class Student2
        {
            int rlno;
            string name;
            double cgpa;

            public int Rlno
            {
                get { return rlno; }
                set { rlno = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public double Cgpa
            {
                get { return cgpa; }
                set { cgpa = value; }
            }

            public void showdata()
            {
                Console.WriteLine(rlno + "\t" + name + "\t" + cgpa);
            }
        }
        class PropertyDemo
        {
            static void Main(string[] args)
            {
                
                // Create and initialize three Student1 objects
                Student2 s1 = new Student2
                {
                    Rlno = 11,
                    Name = "Rahul",
                    Cgpa = 6.9
                };

                Student2 s2 = new Student2
                {
                    Rlno = 12,
                    Name = "Priya",
                    Cgpa = 8.5
                };

                Student2 s3 = new Student2
                {
                    Rlno = 13,
                    Name = "Aman",
                    Cgpa = 7.3
                };

                // Display the header
                Console.WriteLine("RollNo" + "\t" + "Name" + "\t" + "CGPA");

                // Display data of all students
                s1.showdata();
                s2.showdata();
                s3.showdata();

            }

        }

    }
}
