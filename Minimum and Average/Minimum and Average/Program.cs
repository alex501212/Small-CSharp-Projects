using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_and_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

            int minimum = Int32.MaxValue;
            foreach (int value in array)
            {
                if (value < minimum) { minimum = value; }
            }
            Console.WriteLine("Minimum Value: " + minimum);

            int total = 0;
            foreach (int value in array)
            {
                total += value;
            }
            float average = (float)total / array.Length;
            Console.WriteLine("\nAverage Value: " + average);

            Console.ReadKey();
        }
    }
}
