using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB_23FOTCA11003.Inheritance
{
    internal class SingleInh3
    {
        public class A         // base class
        {
            protected int x;

            protected void setA()
            {
                x = 10;
            }
        }

        public class B : A       //sub class of A 
        {
            int y;
            public void setB()
            {
                setA();   // CALLED PROTECTED 
                y = 20;
            }

            public void showValue()
            {
                Console.WriteLine("X: " + x);
                Console.WriteLine("y: " + y);
            }
        }

        class SingleInh
        {
            public static void Main(string[] args)
            {
                B ob = new B();
                 // ob.setA();   PROTECTED only his derived class in use not outside his derived class
                ob.setB();     // value of x is changed from 10 to 50 
                ob.showValue();
            }
        }
    }
}
