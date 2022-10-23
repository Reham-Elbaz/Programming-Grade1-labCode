using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*---------------Arithmetic operators----------------*/

            // increment operator
            int a = 5;
            Console.WriteLine(a);   // output: 5
            Console.WriteLine(a++); // output: 5
            Console.WriteLine(a);   // output: 6

            Console.WriteLine(++a); // output: 7
            Console.WriteLine(a);   // output: 7

            // decrement operator
            double b = 10.5;
            Console.WriteLine(b);   // output: 10.5
            Console.WriteLine(b--); // output: 10.5
            Console.WriteLine(b);   // output: 9.5

            Console.WriteLine(--b); // output: 8.5
            Console.WriteLine(b);   // output: 8.5

            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine();

            // addition operator
            Console.WriteLine("5 + 7 = "+ (5 + 7));     // output: 5 + 7 = 12

            // subtraction operator
            Console.WriteLine("5 - 7 = " + (5 - 7));      // output: 5 - 7 = -2

            // multiplication operator
            Console.WriteLine("5 * 7 = " + (5 * 7));      // output: 5 * 7 = 35

            // division operator
            Console.WriteLine("14 / 7 = " + (14 / 7));      // output: 14 / 7 = 2
            Console.WriteLine("14 / 5 = " + (14 / 5));      // output: 14 / 5 = 2
            Console.WriteLine("14.0 / 5 = " + (14.0 / 5));      // output: 14 / 5 = 2.8

            Console.WriteLine("16.8f / 4.1f = " + (16.8f / 4.1f));   // output: 16.8f / 4.1f = 4.097561
            Console.WriteLine("16.8d / 4.1d = " + (16.8d / 4.1d));   // output: 16.8d / 4.1d = 4.09756097560976
            Console.WriteLine("16.8m / 4.1m = " + (16.8m / 4.1m));   // output: 16.8m / 4.1m = 4.0975609756097560975609756098

            Console.WriteLine("16.8d / 4.1f = " + (16.8d / 4.1f));   // output: 16.8d / 4.1f = 4.097561070920458
            Console.WriteLine("16.8m / 4.1f = " + (16.8m / (decimal)4.1f));   // output: 16.8m / 4.1f = 4.0975609756097560975609756098

            // remainder operator
            Console.WriteLine("14 % 5 = " + (14 % 5));      // output: 14 % 5 = 4
            Console.WriteLine("-14 % 5 = " + (-14 % 5));      // output: -14 % 5 = -4
            Console.WriteLine("14 % -5 = " + (14 % -5));      // output: 14 % -5 = 4
            Console.WriteLine("-14 % -5 = " + (-14 % -5));      // output: -14 % -5 = -4

            Console.WriteLine("2 % 5 = " + (2 % 5));      // output: 2 % 5 = 2

            Console.WriteLine("14.8f % 2.4d = " + (14.8f % 2.4d));      // output: 14.8f % 2.4d = 0.4000001907348638

            // compound assignmet
            int x = 3;
            x *= 4;     // equivalent to   x = x * 4
            Console.WriteLine(x);

            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine();

            // comparison operators
            int m = 3;
            int n = 20;
            float c = 3f;
            Console.WriteLine(m>n);               // output: false        
            Console.WriteLine(m<n);               // output: true
            Console.WriteLine(m<=c);              // output: true
            Console.WriteLine(m>=n);              // output: false

            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine();

            // logical operators
            bool iAmFalse = false;
            Console.WriteLine(!iAmFalse);         // output: true

            bool iAmTrue = true;

            Console.WriteLine(iAmTrue&&iAmFalse);      // output: false
            Console.WriteLine(iAmTrue||iAmFalse);      // output: true
            Console.WriteLine(iAmTrue||true);      // output: true

            // bitwise operators
            Console.WriteLine(~4);              // output: -5
            Console.WriteLine(172 & 137);      // output: 136
            Console.WriteLine(172 | 137);      // output: 173
            Console.WriteLine(172 ^ 137);      // output: 37
            Console.WriteLine(172 << 3);      // output: 1376
            Console.WriteLine(172 >> 3);      // output: 21

            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine();

            // equality operators
            Console.WriteLine(m==c);         // output: true
        }
    }
}
