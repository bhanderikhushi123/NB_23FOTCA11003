using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB_23FOTCA11003.Abstract
{
    public interface a
    {
        void MyMethods();


    }
    public interface b 
    {
        void MyMethodb();
    }
    public class Tests : a , b
    {
        public void MyMethods()
        {
            Console.WriteLine("this is interface method - a method  ");
        }

        public void MyMethodb()
        {
            Console.WriteLine("this is interface method - b method  ");
        }
    }
    
       
    
    internal class multipleinhinterface
    {
        public static void Main(string[] args)
        {
            a ob1 = new Tests();         // this concepts pholymorphijam
            ob1.MyMethods();

            b ob2 = new Tests();
            ob2.MyMethodb();
        }
    }
}
