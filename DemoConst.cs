using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NB_23FOTCA11003
{
    public class Product
    {
        int pid;
        string  pname;
        double price;
        public Product()
        {
            Console.WriteLine("Enter product id:");
            pid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enetr name is :");
            pname = (Console.ReadLine());
            Console.WriteLine( "eneter price is : ");
            price = Convert.ToDouble(Console.ReadLine());

        }

        public void ShowData()
        {
            Console.WriteLine("Roll No is: " + pid);
            Console.WriteLine("Name is: " + pname);
            Console.WriteLine("Semester is: " + price);
           
        }
    }
    class DemoConst
    {
        public static void Main(string[] args)
        {
            Product product = new Product();

            // Call the ShowData method to display product details
            product.ShowData();

            Console.ReadLine(); // Wait for user input to close the console
        }
    }
}
