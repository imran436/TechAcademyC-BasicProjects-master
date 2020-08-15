using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number();
            num.Amount = 5.24785m;
            Console.WriteLine("num\'s amount is {0}", num.Amount);
            Console.ReadLine();
        }
    }
}
