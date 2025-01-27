using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NB_23FOTCA11003
{


    public class products
    {
        int pid;
        string pname;
        double price;

        public products()
        {
            Console.WriteLine("Enter product id:");
            pid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enetr name is :");
            pname = (Console.ReadLine());
            Console.WriteLine("eneter price is : ");
            price = Convert.ToDouble(Console.ReadLine());

        }
        public void ShowData()
        {
            Console.WriteLine("Roll No is: " + pid);
            Console.WriteLine("Name is: " + pname);
            Console.WriteLine("Semester is: " + price);

        }
    }
    class DemoConst2
    {
        public static void Main(string[] args)
        {
            products[] p = new products[2];
            for (int i = 0; i < p.Length; i++)
            {
                p[i] = new products();
            }
            for (int i = 0; i < p.Length; i++)
            {
                p[i].ShowData();
            }

        }
    }
}
