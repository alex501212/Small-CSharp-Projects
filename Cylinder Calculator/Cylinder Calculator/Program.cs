using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cylinder_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints a greeting for the user
            Console.WriteLine("Welcome to Alex's Cylinder Calculator 1.0!"); 

            // Reads the radius input by the user
            Console.WriteLine("\n*Type the Cylinder's Radius and Press the \"Enter\" Key*\n");
            string radius = Console.ReadLine();

            // Reads the height input by the user
            Console.WriteLine("\n*Enter the Cylinder's Height and Press the \"Enter\" Key*\n");
            string height = Console.ReadLine();           

            // Converts the string type input and converts to double variable type
            double radius2 = Convert.ToDouble(radius);
            double height2 = Convert.ToDouble(height);
           
            double pi = 3.141592654;

            // Calculates the volume and surface area of a cylinder
            double volume = pi * radius2 * radius2 * height2;
            double surfacearea = 2 * pi * radius2 * (radius2 + height2);

            // Writes the volume and surface area of the cylinder
            Console.WriteLine("\nThe Cylinder's Volume is: " + volume + " Cubic Units.");
            Console.WriteLine("The Cylinder's Surface Area is: " + surfacearea + " Square Units.");

            Console.WriteLine("\n*Press Any Key to End the Program*");

            // Reads a key to end the program
            Console.ReadKey();
        }
    }
}
