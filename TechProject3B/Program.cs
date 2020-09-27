// Programmer: Nikhil Patel
// Date: 09/27/2020
// Description: This code demonstrates a manual array 

using System;

namespace TechProject3B
{
    class Program
    {
        static void Main(string[] args)
        {

                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

                // for-each loop used
                foreach (int n in numbers)
                {
                    Console.Write(" Elemental Value = " + n);
                    Console.WriteLine("");


                }

            Console.WriteLine("");
            // Exit access for user
            Console.WriteLine(" Press any key to exit the program ");
            // Used to keep the program running
            Console.ReadKey(true);

            
        }
    }
}
