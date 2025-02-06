using System;

namespace NB_23FOTCA11003.Inheritance
{
    public class A
    {
        int x1;
        int x2;

        // Constructor of class A
        public A(int x1, int x2)
        {
            Console.WriteLine("Base class constructor");
            this.x1 = x1;
            this.x2 = x2;
        }

        public void showA()
        {
            Console.WriteLine("x1 : " + x1);
            Console.WriteLine("x2 : " + x2);
        }
    }

    public class B : A
    {
        int y1;
        int y2;

        // Constructor of class B
        public B(int x1, int x2, int y1, int y2) : base(x1, x2)
        {
            Console.WriteLine("Derived class constructor");
            this.y1 = y1;
            this.y2 = y2;
        }

        public void showB()
        {
            Console.WriteLine("y1 : " + y1);
            Console.WriteLine("y2 : " + y2);
        }
    }

    class PiramidConstructor
    {
        public static void Main(string[] args)
        {
            B ob = new B(10, 20, 30, 40); // Object of subclass
            ob.showA(); // Calling method from base class
            ob.showB(); // Calling method from derived class
        }
    }
}
