using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB_23FOTCA11003
{
    internal class StaticDemo2
    {
        public static class Author2
        {
            public static string aname = "XYZ";
            public static string title = "C# PROGRAMMMING";

            public static void update()
            {
                aname = "ABC";
            }
            public static void display()
            {

                Console.WriteLine("Author name is :" + aname);
                Console.WriteLine("Author title is :" + title);
            }
        }
        class StaticDemo
        {
            static void Main(string[] args)
            {
                Console.WriteLine("author information :");
                Author2.display();

                Console.WriteLine("update author information :");
                Author2.update();
                Author2.title = "windows programming";
                Author2.display();
            }
        }
    }
}
