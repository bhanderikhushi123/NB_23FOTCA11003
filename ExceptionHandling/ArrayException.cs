using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB_23FOTCA11003.ExceptionHandling
{
    internal class ArrayException
    {
        public class ArrayIndexOutOfBoundsDemo
        {
            public static void Main(String[] args)
            {
                int[] numbers = { 1, 2, 3, 4, 5 };

                Console.WriteLine("Accessing element at index 1: " + numbers[1]);
                try
                {
                    Console.WriteLine("Accessing element at index 5: " + numbers[5]);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                    
                }
                Console.WriteLine("Remaining Code...");
                Console.WriteLine("this is array of number");
            }
        }

    }
}
