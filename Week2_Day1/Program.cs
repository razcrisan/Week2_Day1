using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day1
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] favNumbers = { 61, 22, 3, 44, 105, 36 };
            //                  //  0   1  2   3    4   5 etc. is how you pull elements, starting with index "0"
            //// this initialized the array so we can start storing stuff in it
            //// useful because you dont have to make 6 different "int" variables

            //string[] studentNames = { "Raz", "Monica", "David", "Brian", "Ali", };
            //// this is how you initialize an array of STRINGS

            //Console.WriteLine(favNumbers[0]);
            //// This is how you pull elements from your desired array

            //Console.WriteLine(studentNames[2]);
            

            //PRACTICE PROBLEMS
            string[] vacationSpots = { "Cancun", "Jamaica", "Ohio", "San Diego", "Aspen", "Romania", "Netherlands", "Paris", "Greece", "Spain" };

            int[] childrenAge = { 6, 8, 9 };

            double[] gpaScale = { 2.3d, 4.0d, 3.2d, 3.5d, 4.2d, 1.4d, 3.0d, 2.0d };

            char[] firstLetter = { 'M', 'K', 'J', 'N' };

            Console.WriteLine(vacationSpots[0] + " " + vacationSpots[9]);
            Console.WriteLine(childrenAge[0]);        
            Console.WriteLine(gpaScale[1]);
            Console.WriteLine(firstLetter[3]);

            // NEW ARRAYS
            // hey we need a new int array, were gonn call it "numbers"
            // new int, inside the brackets this time is how long we want the array
            // new int declares an empty array that can store 4 different things
            // that stores ints in this case
            // now we can store things in these slots

            int[] numbers = new int[4];
            numbers[0] = 43;



        












        }
    }
}
