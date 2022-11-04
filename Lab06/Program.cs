using System;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            // COSE SNIPPET 1
            // prints out "Hello" 10 times
            int i = 1;                               // this is the counter variable
            while (i < 11)                          // as long as i is less than 11,
            {
                Console.WriteLine("Hello");            // print out "Hello",
                i++;                                  // then increase the counter value by 1
                                                      // the previous line can be written--> i += 1; 
            }

            Console.WriteLine("\n\n----*--------*--------*--------*--------*----\n\n");

            // COSE SNIPPET 2
            // prints out numbers from 0 to 9
            int number = 0;                               // this is the counter variable
            while (number < 10)                           // as long as number is less than 10,
            {
                Console.WriteLine(number);                // print out the current value of number,
                number++;                                   // then increase its value by 1
            }
        }
    }
}
