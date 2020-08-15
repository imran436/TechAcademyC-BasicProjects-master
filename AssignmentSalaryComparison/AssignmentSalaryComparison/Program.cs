using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSalaryComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\n" +
                "Person 1\n" +
                "Hourly Rate?");
            double p1Hourly =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            double p1Hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Person 2\n" +
                "Hourly Rate?");
            double p2Hourly = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            double p2Hours = Convert.ToDouble(Console.ReadLine());
            decimal p1AnualSalary = (decimal)p1Hourly * (decimal)p1Hours * 52;
            decimal p2AnualSalary = (decimal)p2Hourly * (decimal)p2Hours * 52;
            bool isP1SalaryMore = p1AnualSalary > p2AnualSalary;
            Console.WriteLine("Annual salary of Person 1: \n" + p1AnualSalary +"\n" +
                "Annual salary of Person 2: \n" + p2AnualSalary + "\n" +
                "Does Person 1 make more money than Person 2? \n"+ isP1SalaryMore.ToString());
            Console.ReadLine();
        }
    }
}
