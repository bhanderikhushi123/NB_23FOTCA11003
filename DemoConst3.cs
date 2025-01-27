using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB_23FOTCA11003
{

    public class product1
    {
        int pid;
        string pname;
        double price;
        static string brand = "DELL";

        public product1()
        {
            Console.WriteLine("Enter product deatils :");
            pid = Convert.ToInt32(Console.ReadLine());
          
            pname = (Console.ReadLine());
           
            price = Convert.ToDouble(Console.ReadLine());

        }
        public void ShowData()
        {
            Console.WriteLine("Enter product deatils :");
            Console.WriteLine( pid + "\t" + pname + "\t" + price + "\t" + brand );

        }
    }
    class DemoConst3
    {
        For(int )
    }
}
