using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB_23FOTCA11003
{
    public static class Author
    {
        public static string aname = "XYZ";
        public static string title = "C# PROGRAMMMING";

        public static void update()
        {
            aname ="ABC";
        }
        public static void display()
        {
       
            Console.WriteLine("Author name is :" +aname);
            Console.WriteLine("Author title is :" + title);
        }
    }
    class StaticDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("author information :");
            Author.display();

            Console.WriteLine("update author information :");
            Author.update();
            Author.display();
        }
    }
}
