using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LMS165
{
    public class Employee: Person//, IQuittable
    {
        public int Id { get; set; }
       // public List<T> Things { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Id: " + Id);
            base.SayName();
        }
        //public void Quit()
        //{
        //    this.Id = 0;
        //    Console.WriteLine("I " + FirstName + " "+ LastName + " Quit!");
        //}
        //public static bool operator== (Employee employee1, Employee employee2)
        //{
        //    bool isEqual = employee1.Id == employee2.Id;
        //    return isEqual;
        //}
        //public static bool operator!= (Employee employee1, Employee employee2)
        //{
        //    bool isEqual = employee1.Id != employee2.Id;
        //    return isEqual;
        //}
    }
}
