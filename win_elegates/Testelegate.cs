using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB_23FOTCA11003.win_elegates
{
    public delegate int UpdateNo(int n);   ///declaration od delegate 
   
    public class Test
    {
        int no;

        public Test(int no)
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
        public int getNumber() {  return no; }

    }
    class Testelegate
    {
        public static void Main(string[] args)
        {
            Test t = new Test(10);
            Console.WriteLine("Actual number:" +t.getNumber());
            UpdateNo add = new UpdateNo(t.addnumber);
            add(20);                //by using delegate we can call method
            Console.WriteLine("Addition number:" + t.getNumber());
            UpdateNo mul = new UpdateNo(t.mulnumber);
            mul(5);
            Console.WriteLine("after Multification : "+ t.getNumber());

        }
    }
}
