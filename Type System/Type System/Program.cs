using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_System
{
    class Program
    {
        static void Main(string[] args)
        {
            byte cars = 255;
            short vans = -123;
            int trucks = -8675;
            long planes = 12389172391273L;
            char boats = 'g';
            sbyte ships = -55;
            ushort helicopters = 23456;
            uint bikes = 41234;
            ulong motorbikes = 1235321413542UL;
            float ufos = 1.12341234f;
            double rockets = 123.123412341234;
            decimal quadbikes = 6.829m;
            bool jets = true;
            string message = "Hello";
            
            Console.WriteLine(cars);
            Console.WriteLine(vans);
            Console.WriteLine(trucks);
            Console.WriteLine(planes);
            Console.WriteLine(boats);
            Console.WriteLine(ships);
            Console.WriteLine(helicopters);
            Console.WriteLine(bikes);
            Console.WriteLine(motorbikes);
            Console.WriteLine(ufos);
            Console.WriteLine(rockets);
            Console.WriteLine(quadbikes);
            Console.WriteLine(jets);
            Console.WriteLine(message);

            Console.ReadKey();
        }
    }
}
