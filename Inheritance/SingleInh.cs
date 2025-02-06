using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB_23FOTCA11003.Inheritance
{

    public class A         // base class
    {
        public int x;
    }

    public class B : A       //sub class of A 
    {
        int y;
        public void setValue()
        {
            x = 10;
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
            ob.setValue();
            ob.showValue();
        }
    }
}
