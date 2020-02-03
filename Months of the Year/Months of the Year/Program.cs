using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Months_of_the_Year
{
    enum monthsofyear { January=1, Febuary=2, March=3, April=4, May=5, June=6, July=7, August=8, September=9, October=10, November=11, December=12 };
    class Program
    {
        static void Main(string[] args)
        {
            int monthnumberint = Convert.ToInt32(Console.ReadLine());

            if (monthnumberint > 0 && monthnumberint <= 12)
            {
                monthsofyear month = (monthsofyear)monthnumberint;
                Console.WriteLine("\nMonth is: " + month);
            }
            else
            {
                Console.WriteLine("\nValue is too high/low.");
            }

            Console.ReadKey();
        }
    }
}
