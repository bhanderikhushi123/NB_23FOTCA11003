using System;

namespace NB_23FOTCA11003.win_delegates
{
    // Delegate declaration
    public delegate int UpdateNo1(int n);

    public class Test1
    {
        int no;

        public Test1(int no)
        {
            this.no = no;
        }

        public int addnumber(int n)
        {
            no = no + n;
            return no;
        }

        public int mulnumber(int n)
        {
            no = no * n;
            return no;
        }

        public int getNumber()
        {
            return no;
        }
    }

    internal class DemoDelegate
    {
        static void Main(string[] args)  // Correct entry point
        {
            Test1 t1 = new Test1(10);
            Console.WriteLine("Actual number: " + t1.getNumber());

            UpdateNo1 add = new UpdateNo1(t1.addnumber);
            UpdateNo1 mul = new UpdateNo1(t1.mulnumber);
            UpdateNo1 comb;
            comb = add + mul;

            comb(5);
            Console.WriteLine("After Multiplication: " + t1.getNumber());
        }
    }
}
