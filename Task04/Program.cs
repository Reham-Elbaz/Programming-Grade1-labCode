using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * This program is to let the user enter a number (from 0 to 10), 
             * then print it in words in English.
             */


            Console.Write("Please, enter the a number (from 0 to 10):");        // just to inform the user what they are going to enter
            int number = int.Parse(Console.ReadLine());

            string numberInWords = "";
            if(number >= 0)
            {
                if (number == 0)
                    numberInWords = "Zero";

                else if (number == 1)                         // use else..if instead of if to optimize the solution, just prevent any other checks if one condition applies.
                    numberInWords = "One";

                else if (number == 2)
                    numberInWords = "Two";

                else if (number == 3)
                    numberInWords = "Three";

                else if (number == 4)
                    numberInWords = "Four";

                else if (number == 5)
                    numberInWords = "Five";

                else if (number == 6)
                    numberInWords = "Six";

                else if (number == 7)
                    numberInWords = "Seven";

                else if (number == 8)
                    numberInWords = "Eight";

                else if (number == 9)
                    numberInWords = "Nine";

                else if (number == 10)
                    numberInWords = "Ten";

                else if(number > 10)
                    Console.WriteLine("Number is too big.");
            }

            if(numberInWords != "")
                Console.WriteLine(numberInWords);

        }
    }
}
