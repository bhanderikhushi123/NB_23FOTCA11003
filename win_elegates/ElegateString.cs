using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB_23FOTCA11003.win_elegates
{
    public delegate void ShowDateTime();
    public class Tests
    {
        public void showDate()
        {
            System.Console.WriteLine("Current date is :" + DateTime.Now.ToShortDateString());
        }
        public void showTime()
        {
            System.Console.WriteLine("Current time is :" + DateTime.Now.ToShortTimeString());
        } 
    }
    class ElegateString
    {
        static void Main(string[] args)
        {
            
            // Create an instance of Tests
           Tests ob = new Tests();

            // Create a delegate instance and assign methods to it
            ShowDateTime dt = new ShowDateTime(ob.showDate);
            dt();

            ShowDateTime tm = new ShowDateTime(ob.showTime);
            tm();

            Console.ReadLine(); // Keeps console open until user input
        }
    }
}
