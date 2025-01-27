using System;

namespace NB_23FOTCA11003
{
    internal class Constructor
    {
        // Fields
        int rlno;
        string name;
        int sem;
        double cgpa;

        // Constructor
        public Constructor()
        {
            Console.WriteLine("INPUT ROLL NO :");
            rlno = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("input name is  : ");
            name = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INPUT sem is  :");
            sem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INPUT cgpa is :");
            cgpa = Convert.ToInt32(Console.ReadLine());

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

    class Program2
    {
        static void Main(string[] args)
        {
            Constructor student = new Constructor(); // Create an instance of Constructor
            student.ShowData(); // Call the method to display data
            Console.ReadLine(); // Wait for user input to close the console
        }
    }
}
