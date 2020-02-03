using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copying_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 6, 4, 2, 8, 7 }; //intial array
            int[] copy = new int[array.Length]; //copy array

            //copy intial array values
            for (int index = 0; index < array.Length; index++) 
            {
                copy[index] = array[index];
            }

            //print intial array values
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write(array[index] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //print copy array values
            for (int index = 0; index < copy.Length; index++)
            {
                Console.Write(copy[index] + " ");
            }

            Console.ReadKey();
        }
    }
}
