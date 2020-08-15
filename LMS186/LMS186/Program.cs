using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LMS186
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Please enter the current day of the week: ");
                string chosenDay = Console.ReadLine();
                chosenDay = chosenDay.ToLower();
                Day day = (Day)Enum.Parse(typeof(Day), chosenDay);
                for(int i=0; i < 7; i++)
                {
                    if(day == (Day)i)
                    {
                        Console.WriteLine("Happy {0}", (Day)i);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
