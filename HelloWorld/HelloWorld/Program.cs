//using directives tell the complier where to find piles of existing code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//a namespace is the biggest way to organize code
//and gathers them into large parts of related code
namespace HelloWorld
{
    //a class is a way of tieing up related data 
    //and methods that use data altogether into one piece of reusable code
    class Program
    {
        //A method (Main is a method) is the smallest way to package up code
        //A method usually is supposed to accomplish only a single, specific goal. 
        static void Main(string[] args)
        {
            //prints the line "Hello World!" in the console
            Console.WriteLine("Hello World!");

            //waits until a key is pressed in order to close the program
            Console.ReadKey();
        }
    }
}//these curly braces mark the start and end of blocks of code
//they here are used to start and end methods, classes and namespaces
