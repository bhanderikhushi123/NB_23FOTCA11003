using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB_23FOTCA11003
{
    
        class student
        {

            // Fields
            int rlno;
            string name;
            int sem;
            double cgpa;

        public student(int rlno , string name , int sem , double cgpa)
            {
                this.rlno = rlno;
                this.name = name;
                this.sem = sem;
                this.cgpa = cgpa;
            }

            public void showdata()
            {
                Console.WriteLine("roll no is : " + rlno);
                Console.WriteLine("name is : " + name);
                Console.WriteLine("sem is :" + sem);
                Console.WriteLine("cgpa is : " +cgpa);
            }
        }

        class parametercon
    {
            public static void main(string[] args)
            {
                parametercon student = new parametercon();
                student.showdata(); // Call the method to display data
                Console.ReadLine();
            }        
        }
    }
