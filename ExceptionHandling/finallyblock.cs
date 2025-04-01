using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB_23FOTCA11003.ExceptionHandling
{
    class finallyblock
    {
        public static void Main(string[] args)
        {
            int no1, no2, result;

            Console.WriteLine("Enter number 1 :");
            no1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 1 :");
            no2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                result = no1 / no2;
                Console.WriteLine("Division of two number :" + result);
            }
            catch (ArrayTypeMismatchException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("this is finally block - MUST be executed ");
                result = no1 + no2;
                Console.WriteLine("addition of two number :" + result);
            }
          
           
        }
    }
}
