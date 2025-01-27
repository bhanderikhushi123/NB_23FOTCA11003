using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB_23FOTCA11003
{
    class constructoruser
    {

        // Fields
        int rlno;
        string name;
        int sem;
        double cgpa;

        // Constructor
        public constructoruser()
        {
            Console.WriteLine("INPUT ROLL NO :");
            rlno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input name is  : ");
            name = (Console.ReadLine());
            Console.WriteLine("INPUT sem is  :");
            sem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INPUT cgpa is :");
            cgpa = Convert.ToDouble(Console.ReadLine());

        }

        // Method to display data
        public void ShowData()
        {
            Console.WriteLine("Roll No is: " + rlno);
            Console.WriteLine("Name is: " + name);
            Console.WriteLine("Semester is: " + sem);
            Console.WriteLine("CGPA is: " + cgpa);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            constructoruser student = new constructoruser(); // Create an instance of Constructor
            student.ShowData(); // Call the method to display data
            Console.ReadLine(); // Wait for user input to close the console
        }
    }
}

