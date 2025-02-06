using System;

namespace NB_23FOTCA11003.Inheritance
{
    // Base class Employee1
    public class Employee1
    {
        protected int eid;
        protected string name;
        protected double baseSalary;

        // Parameterized constructor
        public Employee1(int eid, string name, double baseSalary)
        {
            this.eid = eid;
            this.name = name;
            this.baseSalary = baseSalary;
        }

        // Method to display employee details
        public void ShowEmployeeDetails()
        {
            Console.WriteLine("Employee ID: " + eid);
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Base Salary: " + baseSalary);
        }
    }

    // Derived class Salary1
    public class Salary1 : Employee1
    {
        private double da;   // Dearness Allowance (40%)
        private double hra;  // House Rent Allowance (20%)
        private double grossSalary;

        // Constructor to initialize salary details
        public Salary1(int eid, string name, double baseSalary) : base(eid, name, baseSalary)
        {
            hra = CalcHRA();  // Calculate HRA
            da = CalcDA();    // Calculate DA
            grossSalary = baseSalary + hra + da; // Calculate Gross Salary
        }

        // Method to calculate HRA (20% of base salary)
        public double CalcHRA()
        {
            return baseSalary * 0.2;
        }

        // Method to calculate DA (40% of base salary)
        public double CalcDA()
        {
            return baseSalary * 0.4;
        }

        // Method to display salary details
        public void ShowSalaryDetails()
        {
            ShowEmployeeDetails();
            Console.WriteLine("HRA (20%): " + hra);
            Console.WriteLine("DA (40%): " + da);
            Console.WriteLine("Gross Salary: " + grossSalary);
        }
    }

    // Main class
    class CalculateSalary1
    {
        public static void Main(string[] args)
        {
            // Creating an object of Salary1 class
            Salary1 emp1 = new Salary1(101, "AAA", 50000);

            // Displaying salary details
            emp1.ShowSalaryDetails();
        }
    }
}
