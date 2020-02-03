using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remainders
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine(a + "/" + b + " is " + quotient + " remainder " + remainder);

            int idk = b * quotient + remainder;

            Console.WriteLine(idk);

            Console.ReadKey();
        }
    }
}
