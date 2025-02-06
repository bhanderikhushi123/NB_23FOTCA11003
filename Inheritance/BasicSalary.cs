using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* class emoployee 
 * {
 *    int eid ;//
 *    string name ;
 *    double basesalary ;
 *    
 *    public employye() 
 *    {
 *    }
 * }

public class salary : employee 
{
        double da ; 40 % basic salary
        double hra ; 20 % basic salary
        double grosssalary ;
}
namespace NB_23FOTCA11003.Inheritance
{
    internal class BasicSalary
    {
    }
}
*/



namespace NB_23FOTCA11003.Inheritance
{
    public class Employee     // Base class Employee
    {
        protected int eid;
        protected string name;
        protected double baseSalary;

       

        // Parameterized constructor
        public Employee(int eid, string name, double baseSalary)
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
    public class Salary : Employee        // Derived class Salary
    {
        private double da;           // (40%)
        private double hra;          //(20%)
        private double grossSalary;

        
        public Salary(int eid, string name, double baseSalary) : base(eid, name, baseSalary)
        {
            da = 0.40 * baseSalary;  // 40% of base salary
            hra = 0.20 * baseSalary; // 20% of base salary
            grossSalary = baseSalary + da + hra;
        }


        public void ShowSalaryDetails()
        {
            ShowEmployeeDetails();
            Console.WriteLine("DA (40%): " + da);
            Console.WriteLine("HRA (20%): " + hra);
            Console.WriteLine("Gross Salary: " + grossSalary);
        }
    }

    class BasicSalary
    {
        public static void Main(string[] args)
        {
         
            Salary emp1 = new Salary(101, "AAA", 50000);

          
            emp1.ShowSalaryDetails();
        }
    }
}

