using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_and_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Alex's Even and Odd Calculator\n");
            Console.WriteLine("*Please Enter a Number and Press the \"Enter\" Key*\n");

            string input = Console.ReadLine();
            int remainder1 = Convert.ToInt32(input);

            int remainder2 = remainder1 % 2;
            bool even;

            if(remainder2 == 0)
                even = true;
            else
                even = false;

            if(even)
            {
                Console.WriteLine("\nThis Number is Even");
            }
            else
            {
                Console.WriteLine("\nThis Number is Odd");
            }

            Console.WriteLine("\n*Press any Key to End the Program*");
            Console.ReadKey();
        }
    }
}
