using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_a_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {         
            float b = 1.5f; //b = base
            float h = 4f; // h = height

            float area = 0.5f * b * h; //0.5 * b * h = area of a triangle

            Console.WriteLine("Base: " + b);
            Console.WriteLine("Height: " + h);
            Console.WriteLine("Area: " + area);

            Console.ReadKey();
        }
    }
}
