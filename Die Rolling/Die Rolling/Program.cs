using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Rolling
{
    class Program
    {
        static void Main(string[] args)
        {
            start();
        }
        static void start()
        {
            Random random = new Random();

            Console.WriteLine("*Enter the Number of Dice you Want to Roll*");
            int input = Convert.ToInt32(Console.ReadLine());

            int total = 0;

            do
            {
                int roll = random.Next(6) + 1;
                input = input - 1;
                total += roll;

                if (input >= 1)
                {
                    Console.Write(roll + " + ");
                }
                else
                    Console.Write(roll);
            }
            while (input >= 1);

            Console.Write(" = " + total);

            Console.WriteLine("\n*Do you Want Re-roll?*");
            string leave = "yes";
            do
            {
                leave = Console.ReadLine();
                if (leave == "no" || leave != "no" && leave != "yes")
                {
                    System.Environment.Exit(1);
                }
                else
                {
                    start();
                }
            }
            while (leave == "yes");
        }
    }
}