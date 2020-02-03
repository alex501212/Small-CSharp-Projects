using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Alex's Calculator!");

            Console.WriteLine("\n*Please Input the First Value*\n");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n*Please Input the Operator*\n");
            String calculationsign = Console.ReadLine();

            Console.WriteLine("\n*Please Input the Second Value*\n");
            int input2 = Convert.ToInt32(Console.ReadLine());

            int finalcalc;

            switch (calculationsign)
            {
                case "+":
                    finalcalc = input1 + input2;
                    break;
                case "-":
                    finalcalc = input1 - input2;
                    break;
                case "*":
                    finalcalc = input1 * input2;
                    break;
                case "/":
                    finalcalc = input1 / input2;
                    break;
                case "%":
                    finalcalc = input1 % input2;
                    break;
                case "^":
                    finalcalc = (int)Math.Pow(input1, input2);
                    break;
                default:
                    Console.WriteLine(calculationsign + " Is Not a Valid Operator.");
                    finalcalc = 0;
                    break;
            }

            Console.WriteLine("\n" + input1 + " " + calculationsign + " " + input2 + " = " + finalcalc + "\n\n*Press the Any Key to End the Program*");

            Console.ReadKey();  
        }
    }
}
