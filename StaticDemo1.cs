using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB_23FOTCA11003
{
    internal class StaticDemo1
    {
        public static class Author1
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
                Author1.display();

                Console.WriteLine("update author information :");
                Author1.update();
                Author1.title = "windows programming";
                Author1.display();
            }
        }
    }
}
