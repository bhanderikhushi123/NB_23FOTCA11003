using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB_23FOTCA11003.ExceptionHandling
{
    public class DivisionException : Exception
    {

        public override string Message
        {
            get
            {
                return "division is not possible.. Due to inappropriate division";
            }
        }
    }

    class userDefinedException
    {
        static void Main(string[] args)
        {
            int no1, no2, result;

            Console.WriteLine("Enter number 1 :");
            no1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 1 :");
            no2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (no1 % no2 != 0)
                {
                    throw new DivisionException();
                }
                else
                {
                    result = no1 / no2;
                    Console.WriteLine("Division of two number :" + result);
                }
            }
            catch(DivisionException ob)
            {
                Console.WriteLine(ob.Message);
            }

        }
    }

}
