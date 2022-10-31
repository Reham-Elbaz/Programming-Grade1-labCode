using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * This program is to convert a shifted integer to binary and hexadecimal. Assume you will shift right and left.
             * 1- Accept the integer from the user.
             * 2- Accept the shifting amount from the user.
             * 3- Perform both shifting.
             * 4- Convert the original integer, right-shifted, and left-shifted to binary and hexadecimal.
             * 5- Show the results.
            */

            Console.Write("Please, enter an integer number to convert: ");
            int intNum = int.Parse(Console.ReadLine());
            Console.Write("Please, enter a shift amount: ");
            int shiftAmount = int.Parse(Console.ReadLine());

            int rightShift = intNum >> shiftAmount;
            int leftShift = intNum << shiftAmount;

            
            Console.WriteLine("\n\n----*----*----*----*----*----*----*----*----*\n\n");

            Console.WriteLine("--The original int--");
            Console.WriteLine("The binary form -->  {0}", Convert.ToString(intNum, 2));
            Console.WriteLine("The hexadecimal form -->  {0}", Convert.ToString(intNum, 16));

            Console.WriteLine("\n----*----*----*----*----*----*----*----*----*\n");

            Console.WriteLine("--Right-shift--");
            Console.WriteLine("The binary form -->  {0}", Convert.ToString(rightShift, 2));
            Console.WriteLine("The hexadecimal form -->  {0}", Convert.ToString(rightShift, 16));

            Console.WriteLine("\n----*----*----*----*----*----*----*----*----*\n");

            Console.WriteLine("--Left-shift--");
            Console.WriteLine("The binary form -->  {0}", Convert.ToString(leftShift, 2));
            Console.WriteLine("The hexadecimal form -->  {0}", Convert.ToString(leftShift, 16));
        }
    }
}
