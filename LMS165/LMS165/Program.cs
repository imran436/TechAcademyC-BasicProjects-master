using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS165
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee test = new Employee() { FirstName = "test", LastName = "overload", Id = 32 };
            //Employee sample = new Employee() { FirstName = "Sample", LastName = "Student", Id = 32 };
            //bool testing = test == sample;
            //sample.SayName();
            //Console.ReadLine();
            //IQuittable emp = new Employee() {FirstName ="Test", LastName ="Quittable", Id =33 };
            //emp.Quit();
            //Console.ReadLine();


            //Employee<string> employee = new Employee<string>();
            //employee.FirstName = "Test";
            //employee.LastName = "student";

            //employee.SayName();           
            //employee.Things = new List<string>() { "thing 1", "thing 2", "thing 3", "thing 4", "thing 5" };

            //Console.WriteLine("Employee Things: \r\n");
            //foreach (string thing in employee.Things)
            //{
            //Console.WriteLine( thing + "\r\n");
            //}            
            //Console.ReadLine();

            //Employee<int> employee = new Employee<int>();

            //employee.FirstName = "Test";
            //employee.LastName = "student";

            //employee.SayName();
            //employee.Things = new List<int>() { 2, 12, 56, 28, 97 };

            //Console.WriteLine("Employee Things: \r\n");
            //foreach (int thing in employee.Things)
            //{
            //    Console.WriteLine(thing + "\r\n");
            //}
            List<Employee> employeeList = new List<Employee>();

            for (int i =0; i < 10; i++)
            {
                Employee employee = new Employee();
                employee.Id = i;
                if(i == 0)
                {
                    employee.FirstName = "Joe";
                    employee.LastName = "Smith";
                }
                else if(i == 1)
                {
                    employee.FirstName = "Jane";
                    employee.LastName = "Jones";
                }
                else if (i == 2)
                {
                    employee.FirstName = "Bob";
                    employee.LastName = "Johnson";
                }
                else if (i == 3)
                {
                    employee.FirstName = "Ted";
                    employee.LastName = "Daniels";
                }
                else if (i == 4)
                {
                    employee.FirstName = "Jared";
                    employee.LastName = "wilson";

                }
                else if (i == 5)
                {
                    employee.FirstName = "Joe";
                    employee.LastName = "Jacobs";
                }
                else if (i == 6)
                {
                    employee.FirstName = "Kate";
                    employee.LastName = "Scott";
                }
                else if (i == 7)
                {
                    employee.FirstName = "Karen";
                    employee.LastName = "Rodgers";
                }
                else if (i == 8)
                {
                    employee.FirstName = "Darius";
                    employee.LastName = "Anderson";
                }
                else if (i == 9)
                {
                    employee.FirstName = "Jon";
                    employee.LastName = "Buck";
                }
                employeeList.Add(employee);
            }
            //List<Employee> employeesNamedJon = new List<Employee>();
            //foreach(Employee emp in employeeList)
            //{
            //    if(emp.FirstName == "Joe")
            //    {
            //        employeesNamedJon.Add(emp);
            //    }
            //}
            List<Employee> employeesNamedJon = employeeList.Where(x => x.FirstName == "Joe").ToList();
            List<Employee> empIdGreater5 = employeeList.Where(x => x.Id >= 5).ToList();
            Console.ReadLine(); 
        }
    }
}
