using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positive_or_Negative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Alex's Positive or Negative Calculator!"); //Prints Welcome Message

            Console.WriteLine("\n*Enter the First Number*\n"); //Writes line to tell user to enter number
            string input = Console.ReadLine(); //Reads the user input as a string
            int number1 = Convert.ToInt32(input); //converts the string input to an int

            Console.WriteLine("\n*Enter the Second Number*\n"); //Writes line to tell user to enter another number
            input = Console.ReadLine(); //Reads the user input as a string
            int number2 = Convert.ToInt32(input); //converts the string input to an int

            //if it either numbers are equal to 0 then a message will be print to the user
            if (number1 == 0 || number2 == 0)
            {
                Console.WriteLine("\nThe Result Wont be Positive or Negative, as One of the Numbers You Entered was 0"); 
            }
            else
            {
                //This finds out of if each of the numbers are positive
                bool number1Positive;
                bool number2Positive;

                if (number1 > 0) { number1Positive = true; }
                else { number1Positive = false; }

                if (number2 > 0) { number2Positive = true; }
                else { number2Positive = false; }

                //If they are both positive or both negative then a message will be print to the user to say that the result will be negative
                if ((number1Positive && number2Positive) ||
                    (!number1Positive && !number2Positive))
                {
                    Console.WriteLine("\nThe Result Will be Positive.\n");
                }
                else
                {
                    Console.WriteLine("\nThe product Will be Negative.\n"); //if the result is negative then this message will be print to the user
                }
            }
            Console.ReadKey(); //wait for the user to press a key in order to end the program
        }
    }
}
