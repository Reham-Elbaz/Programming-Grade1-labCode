using System;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            // CODE SNIPPET 1
            Console.WriteLine("\n----*----*----*----*----*----if statement----*----*----*----*----*----*\n");

            if (true)
            {
                Console.WriteLine("This will print true from the if statement!\n");         // this line will be printed all the time as the condition here is always true
            }
            Console.WriteLine("This will be printed from outside the if statement!\n");     // this line will be printed all the time as it's outside the if statement

            if (false)
            {
                Console.WriteLine("This will never be printed!\n");                        // this line will never be printed as the condition here is always false
            }


            // CODE SNIPPET 2
            Console.WriteLine("\n----*----*----*----*----*----if else statement----*----*----*----*----*----*\n");

            Console.WriteLine("Enter 'yes' or anything else:");
            string evaluateMe1 = Console.ReadLine();
            if (evaluateMe1 == "yes")
            {
                Console.WriteLine("You entered yes.");                                   // this line will be printed if the user entered yes
            }
            else
            {
                Console.WriteLine("Invalid input.");                                  // this line will be printed if the user entered anything else
            }


            // CODE SNIPPET 3
            Console.WriteLine("\n----*----*----*----*----*----if else if statement----*----*----*----*----*----*\n");

            Console.WriteLine("Enter 'yes' or 'no':");
            string evaluateMe2 = Console.ReadLine();
            if (evaluateMe2 == "yes")
            {
                Console.WriteLine("You entered yes.");                                   // this line will be printed if the user entered yes
            }
            else if (evaluateMe2 == "no")
            {
                Console.WriteLine("You entered no.");                                  // this line will be printed if the user entered no
            }
            else
            {
                Console.WriteLine("Invalid input.");                                  // this line will be printed if the user entered anything else
            }


            // CODE SNIPPET 4
            Console.WriteLine("\n----*----*----*----*----*----conditional ternary operator----*----*----*----*----*----*\n");

            // CODE SNIPPET 4.1

            Console.WriteLine("Enter 'yes' or anything else:");
            string evaluateMe3 = Console.ReadLine();

            string result1 = (evaluateMe3 == "yes") ? "You entered yes." : "Invalid input.";         // this equivalent to the previous (if else) statement

            Console.WriteLine(result1);


            // CODE SNIPPET 4.2
            Console.WriteLine("\n----*----*----*----*----*----conditional ternary operator----*----*----*----*----*----*\n");

            Console.WriteLine("Enter 'yes' or 'no':");
            string evaluateMe4 = Console.ReadLine();

            string result2 = (evaluateMe4 == "yes") ? "You entered yes." : ((evaluateMe4 == "no") ? "You entered no" : "Invalid input.");         // this equivalent to the previous (if else if) statement

            Console.WriteLine(result2);


            // CODE SNIPPET 5
            Console.WriteLine("\n----*----*----*----*----*----switch statement----*----*----*----*----*----*\n");

            Console.WriteLine("Enter 'yes' or 'no' or 'maybe' in capital or small letter:");
            string evaluateMe5 = Console.ReadLine();

            switch (evaluateMe5)
            {
                case "yes":                                                                 // in case user entered 'yes',
                case "YES":                                                                 // or in case user entered 'YES',
                    Console.WriteLine("You entered yes.");                                  // this line will be printed.
                    break;

                case "no":                                                            // in case user entered 'no',
                case "NO":                                                            // or in case user entered 'NO',
                    Console.WriteLine("You entered no.");                             // this line will be printed.
                    break;

                default:                                                            // in case user entered anything else,
                    Console.WriteLine("Invalid input.");                            // this line will be printed.
                    break;

            }


            // CODE SNIPPET 6
            Console.WriteLine("\n\n----*----*----*----*----*----Exercises----*----*----*----*----*----*\n");

            // CODE SNIPPET 6.1
            Console.WriteLine("\n----*----*----Exercise 1 : Enter your degree to print your grade----*----*\n");
            Console.WriteLine("Excellent-->                 85 <= degree <= 100");
            Console.WriteLine("Very good-->                 75 <= degree < 85");
            Console.WriteLine("Good-->                      65 <= degree < 75");
            Console.WriteLine("Pass-->                      50 <= degree < 65");
            Console.WriteLine("Fail-->                      50 > degree\n\n");

            Console.WriteLine("Enter your degree:");
            int degree = int.Parse(Console.ReadLine());

            // this snippet of code will check the degree for every single if statement
            if (degree <= 100 && degree >= 85)
                Console.WriteLine("Excellent");
            if (degree < 85 && degree >= 75)
                Console.WriteLine("Very Good");
            if (degree < 75 && degree >= 65)
                Console.WriteLine("Good");
            if (degree < 65 && degree >= 50)
                Console.WriteLine("Pass");
            if (degree < 50)
                Console.WriteLine("Fail");
            else
                Console.WriteLine("\nCongratualions!");          // this line will be excuted each time the degree is greater than or equal 50


            // CODE SNIPPET 6.2
            Console.WriteLine("======================================");
            // so, we rather use if else if statement to avoid unnecessary checks.
            // the next snippet of code is equivalent to the previous.

            if (degree <= 100 && degree >= 85)
                Console.WriteLine("Excellent");
            else if (degree < 85 && degree >= 75)
                Console.WriteLine("Very Good");
            else if (degree < 75 && degree >= 65)
                Console.WriteLine("Good");
            else if (degree < 65 && degree >= 50)
                Console.WriteLine("Pass");
            else if (degree < 50)
                Console.WriteLine("Fail");
            else
                Console.WriteLine("Invalid input.");


            // CODE SNIPPET 7
            Console.WriteLine("\n----*----*----Exercise 2 : Enter 2 numbers and an operator----*----*\n");
            Console.Write("Enter the first operand: ");
            float operand1 = float.Parse(Console.ReadLine());
            Console.Write("Enter the operator (+ or - or * or /): ");
            char myOperator = char.Parse(Console.ReadLine());
            Console.Write("Enter the second operand: ");
            float operand2 = float.Parse(Console.ReadLine());

            float myResult = 1;          // assign the variable to be able to use it in the switch statement,  1 is used here to avoid dividing 0

            switch(myOperator)
            {
                case '+':
                    myResult = operand1 + operand2;
                    break;
                case '-':
                    myResult = operand1 - operand2;
                    break;
                case '*':
                    myResult = operand1 * operand2;
                    break;
                case '/':
                    myResult = operand1 / operand2;
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }

            Console.WriteLine("{0} {1} {2} = {3}", operand1, myOperator, operand2,  myResult);


            // CODE SNIPPET 8
            Console.WriteLine("\n----*----*----Exercise 3 : Check whether an integer number is even or odd----*----*\n");
            // CODE SNIPPET 8.1
            // using if else
            Console.Write("Enter an integer number: ");
            int checkMeEvenOrOdd1 = int.Parse(Console.ReadLine());

            if(checkMeEvenOrOdd1 % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");

            // CODE SNIPPET 8.2
            // using switch
            Console.WriteLine("======================================");
            Console.Write("Enter an integer number: ");
            int checkMeEvenOrOdd2 = int.Parse(Console.ReadLine());

            int remainder = checkMeEvenOrOdd2 % 2;

            switch(remainder)
            {
                case 0:
                    Console.WriteLine("Even");
                    break;

                default:
                    Console.WriteLine("Odd");
                    break;
            }


            // CODE SNIPPET 9
            Console.WriteLine("\n----*----*----Exercise 4 : Check whether or not all the three points fall on one straight line.----*----*\n");
            // CODE SNIPPET 8.1
            // using if else

            Console.WriteLine("Enter the values of x1 and y1 coordinates of first point:");
            int x1 = Convert.ToInt32(Console.ReadLine());           // similar to int.Parse
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the values of x2 and y2 coordinates of second point:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the values of x3 and y3 coordinates of third point:");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            float slope1 = y2 - y1 / x2 - x1;
            float slope2 = y3 - y1 / x3 - x1;
            float slope3 = y3 - y2 / x3 - x2;
            if (slope1 == slope2 && slope1 == slope3)
            {
                Console.WriteLine("\nAll points are fall on one straight line ");
            }
            else
            {
                Console.WriteLine("\nAll points are not fall on one straight line");
            }
            Console.ReadKey();

        }
    }
}
