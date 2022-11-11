using System;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            // COSE SNIPPET 1
            // prints out "Hello" 10 times using while
            int i = 1;                               // i is the loop variable
            while (i < 11)                          // as long as i is less than 11,
            {
                Console.WriteLine("Hello");            // print out "Hello",
                i++;                                  // then increase the loop variable value by 1
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

            Console.WriteLine("\n\n----*--------*--------*--------*--------*----\n\n");

            // COSE SNIPPET 3
            // prints out "Hello" 10 times using for
            for (int c = 0; c < 10; c++)
            {
                Console.WriteLine("Hello");
            }

            // the previous is equivalent to

            /*
            int c;                        // you can declare c here, but you can't say (int c = 0;) here.
            for (c = 0; c < 10; c++)            // you must give c a value inside the header.
            {
                Console.WriteLine("Hello");
            }
            */

            Console.WriteLine("\n\n----*--------*--------*--------*--------*----\n\n");

            // COSE SNIPPET 4
            // prints out "Hello" 10 times using do..while
            int a = 0;
            do
            {
                Console.WriteLine("Hello");      // this line will be executed for the first time no matters the condition is.
                a++;
            } while (a < 10);

            Console.WriteLine("\n\n----*--------*--------Exercises--------*--------*----\n");
            Console.WriteLine("----*--------*--------Exercise 1: Sum of first 10 numbers--------*--------*----\n\n");

            // Write a C# program to find the sum of first 10 natural numbers.
            // COSE SNIPPET 5.1
            // using for loop

            int sum = 0;
            for (int Number = 1; Number <= 10; Number++)
            {
                sum += Number;
            }
            Console.WriteLine("The sum of first 10 natural numbers is " + sum);

            Console.WriteLine("\n----*--------*----------------*--------*----\n");
            // COSE SNIPPET 5.2
            // using while loop

            int Number_ = 1;
            int sum2 = 0;
            while (Number_ <= 10)
            {
                sum2 += Number_;
            }
            Console.WriteLine("The sum of first 10 natural numbers is " + sum);


            Console.WriteLine("\n----*--------*--------Exercise 2: Print natural numbers up to n--------*--------*----\n\n");

            // COSE SNIPPET 6
            // Write a program in C# to display n terms of natural number.
            // ask the user to enter n (how many number they want to display).

            Console.WriteLine("Enter how many number you want to display");
            int n = int.Parse(Console.ReadLine());

            for (int num = 1; num <= n; num++)
            {
                Console.Write(num + ", ");
            }


            Console.WriteLine("\n----*--------*--------Exercise 3: Average of numbers from y to z--------*--------*----\n\n");

            // COSE SNIPPET 7
            // Write a C# Sharp to find the average of of numbers from m to n.

            Console.Write("Start from: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("End at: ");
            int z = int.Parse(Console.ReadLine());

            int sum3 = 0;
            for (int num = y; num <= z; num++)
            {
                sum3 += num;
            }

            float average = (float)sum3 / (z - y + 1);          // convert sum3 to float to get a floating point result
            Console.WriteLine("The average of natural numbers from {0} to {1} is {2}", y, z, average);

            Console.WriteLine("\n----*--------*--------Exercise 4: Odd numbers up to x--------*--------*----\n\n");

            // COSE SNIPPET 8
            // Write a program in C# to display the odd numbers up to number x.

            Console.Write("Up to: ");
            int x = int.Parse(Console.ReadLine());

            for (int k = 1; k <= x; k += 2)
            {
                Console.Write(k + ", ");
            }

            /*
             * another way to print odd numbers
             * 
                for (int k = 1; k <= x; k++)
                {
                    if(w % 2 != 0)
                        Console.Write(k + ", ");
                }
             */
            Console.WriteLine("\n----*--------*--------Exercise 5: Print even numbers in reverse order--------*--------*----\n\n");

            // Write a program in C# to display the even numbers from number t to 0.
            // COSE SNIPPET 9.1
            // using for loop

            Console.Write("Up to: ");
            int t = int.Parse(Console.ReadLine());

            for (int w = t; w >= 0; w--)
            {
                if (w % 2 == 0)
                    Console.Write(w + ", ");
            }

            Console.WriteLine("\n----*--------*----------------*--------*----\n");

            // COSE SNIPPET 9.2
            // using while loop

            int b = t;
            while (b >= 0)
            {
                if (b % 2 == 0)
                    Console.Write(b + ", ");

                b--;
            }


        }
    }
}
