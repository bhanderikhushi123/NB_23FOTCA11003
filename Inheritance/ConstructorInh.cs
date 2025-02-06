using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB_23FOTCA11003.Inheritance
{
    public class A
    {
        public A()
        {
            Console.WriteLine(" main class constructor ");
        }

    }

    public class B : A
    {  //sub class of A
        public B()     
        {
            Console.WriteLine("Derived class CONSTRUCTOR");
        }
    }

    class ConstructorInh
    {

        static void Main(string[] args)
        {
            B ob = new B();
        }
        
    }
}
