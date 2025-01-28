using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB_23FOTCA11003.propertyc_Demo
{

    public class Student1
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
            Student1 s1 = new Student1();
            s1.Rlno = 11;
            s1.Name = "Rahul";
            s1.Cgpa = 6.9;
            Console.WriteLine("RollNo" + "\t" + "Name" + " \t" + "CGPA");
            s1.showdata();
        }

    }

}

