using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB_23FOTCA11003.Abstract
{
    public interface A
    {
        void MyMethod();
        

    }
    public class Test : A
    {
        public void MyMethod()
        {
            Console.WriteLine("this is interface method  ");
        }
    }
    internal class abdemo2
    {
        public static void Main(string[] args)
        {
            A ob = new Test();  // this concepts pholymorphijam
            ob.MyMethod();
        }
    }
}
