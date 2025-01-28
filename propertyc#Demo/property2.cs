    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace NB_23FOTCA11003.propertyc_Demo
    {
        public class Time
        {
            int hour;
            int min;
            int sec;
            string t;

            public Time()
            {
                // Get values of hour, min, and sec from the user

                Console.Write("Enter hours : ");
                hour = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter minutes : ");
                min = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter seconds : ");
                sec = Convert.ToInt32(Console.ReadLine());

                UpdateTimeString(); 
            }

            private void UpdateTimeString()
            {
                t = $"{hour:D2}:{min:D2}:{sec:D2}";
            }

            public void ShowTime()
            {
                // Display the current time
                Console.WriteLine($"Time is: {t}");
            }

            public void Increment()
            {
            
                sec += 1;
                if (sec >= 60)
                {
                    sec = 0;
                    min += 1;

                    if (min >= 60)
                    {
                        min = 0;
                        hour += 1;

                        if (hour >= 24)
                        {
                            hour = 0;
                        }
                    }
                }

                UpdateTimeString(); 

                // Display the incremented time
                Console.WriteLine($"Incremented Time is: {t}");
            }
        }

        internal class Property2
        {
            static void Main(string[] args)
            {
          
                Time t = new Time();
                t.ShowTime();

                // Increment time by 1 second and display the updated time
                Console.WriteLine("Incrementing time by 1 second...");
                t.Increment();

                Console.ReadLine(); 
            }
        }
    }
