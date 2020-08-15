using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            bool hasdui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int numberOfTickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified?");
            bool qualified = ((age > 15) && (hasdui == false) && (numberOfTickets <= 3));
            Console.WriteLine(qualified.ToString());
            Console.ReadLine();
        }
    }
}
