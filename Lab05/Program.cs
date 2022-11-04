using System;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            // CODE SNIPPET 1.1
            // if and only if a=100 and b=200 , print their values
            // using complex logical expression

            int a = 100;
            int b = 200;

            if(a==100 && b==200)
                Console.WriteLine("a= {0} and b= {1}", a, b);            // you can put {} or remove it as long as you'll write one line inside the if block

            // CODE SNIPPET 1.2
            // using nested if statements

            if(a==100)
            {
                if(b==200)
                    Console.WriteLine("a= {0} and b= {1}", a, b);
            }

            // CODE SNIPPET 1.3

            if (a == 100)
            {
                if (b == 200)
                {
                    Console.WriteLine("a= {0} and b= {1}", a, b);
                }
            }

            // CODE SNIPPET 1.1 is equivalent to CODE SNIPPET 1.2 and CODE SNIPPET 1.3

            Console.WriteLine("\n\n----*--------*--------*--------*--------*----\n\n");
            Console.WriteLine("----*--------*--------Exercises--------*--------*----\n");
            Console.WriteLine("\n\n----*--------Exercise 1: square or rectangle--------*----\n\n");
            /*
             * accept length of 2 sides from the user
             * if both sides are equal, print square.
             * if not equal, print rectangle
             */

            // CODE SNIPPET 2.1
            // using if-else

            Console.WriteLine("Enter length of 2 sides:");
            float side1 = float.Parse(Console.ReadLine());
            float side2 = float.Parse(Console.ReadLine());

            if (side1 == side2)
                Console.WriteLine("Square");
            else
                Console.WriteLine("Rectangle");

            // CODE SNIPPET 2.2
            // using switch-case

            bool isEqual = (side1 == side2);        // I'll check whether both sides are equal, this variable will be true, otherwise false.

            switch (isEqual)
            {
                case true:
                    Console.WriteLine("Square");
                    break;

                default:
                    Console.WriteLine("Rectangle");
                    break;
            }

            Console.WriteLine("\n\n----*--------*--------*--------*--------*----\n\n");
            Console.WriteLine("----*--------Exercise 2: Check the speed--------*----\n\n");
            /*
             * let the user enter the speed, and check its categories according to the following:
             * up to 10 km/h --> slow
             * > 10 km/h to 50 km/h --> average
             * > 50 km/h to 150 km/h --> fast
             * > 150 km/h --> very fast
             */
            // CODE SNIPPET 3

            Console.WriteLine("Enter your car speed:");
            float speed = float.Parse(Console.ReadLine());

            if (speed <= 10)
                Console.WriteLine("Slow");
            else if (speed > 10 && speed <= 50)
                Console.WriteLine("Average");
            else if (speed > 50 && speed <= 150)
                Console.WriteLine("Fast");
            else
                Console.WriteLine("Very fast");

            Console.WriteLine("\n\n----*--------*--------*--------*--------*----\n\n");
            Console.WriteLine("----*--------Exercise 3: Give me bonus--------*----\n\n");
            /*
             * let the user enter their salary, and add a bonus to them according to the following:
             * up to 2000$ --> 5% bonus
             * > 2000$ to 5000$ --> 7.5% bonus
             * > 5000$ to 10000$ --> 10% bonus
             * > 10000$ to 30000$ --> 15% bonus
             * otherwise print "Invalid operation"
             * output: salary after bonus rounded to 2 decimal places after floating point اقرب لأقرب رقمين بعد العلامة
             * (for example, if it's 13.56543355, I'd like to show to 13.57)
             */
            // CODE SNIPPET 4

            Console.WriteLine("Enter your salary:");
            float salary = float.Parse(Console.ReadLine());
            float bonus;
            float salaryAfterBonus = 0;

            if (salary <= 2000)
            {
                bonus = 5f / 100;
                salaryAfterBonus = salary + (salary * bonus);
            }
            else if (salary > 2000 && salary <= 5000)
            {
                bonus = 7.5f / 100;
                salaryAfterBonus = salary + (salary * bonus);
            }
            else if (salary > 5000 && salary <= 10000)
            {
                bonus = 10f / 100;
                salaryAfterBonus = salary + (salary * bonus);
            }
            else if (salary > 10000 && salary <= 30000)
            {
                bonus = 15f / 100;
                salaryAfterBonus = salary + (salary * bonus);
            }
            else
                Console.WriteLine("Invalid operation");

            if (salaryAfterBonus != 0)
            {
                // to round a floating-point number, we use Math.Round
                double salaryRounded = Math.Round(salaryAfterBonus, 2);        // double is used because we deal with Math class
                Console.WriteLine("Salary after adding bonus = {0}$", salaryRounded);
            }

            Console.WriteLine("\n\n----*--------*--------*--------*--------*----\n\n");
            Console.WriteLine("----*--------Exercise 4: Say today's name--------*----\n\n");
            /*
             * let the user enter todays number,
             * then print the day name.
             * For example, if the user enters 1, print Saturday.
             * if the user enters 2, print Sunday.
             * and so on.
             * if the number entered exceeded 7, print Invalid day number
             */
            // CODE SNIPPET 5

            Console.WriteLine("Enter day number:");
            int dayNum = int.Parse(Console.ReadLine());

            switch (dayNum)
            {
                case 1:
                    Console.WriteLine("Saturday");
                    break;
                case 2:
                    Console.WriteLine("Sunday");
                    break;
                case 3:
                    Console.WriteLine("Monday");
                    break;
                case 4:
                    Console.WriteLine("Tuesday");
                    break;
                case 5:
                    Console.WriteLine("Wednesday");
                    break;
                case 6:
                    Console.WriteLine("Thursday");
                    break;
                case 7:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;

            }

            Console.WriteLine("\n\n----*--------*--------*--------*--------*----\n\n");
            Console.WriteLine("----*--------Exercise 5: Are 3 points fall in the same line?--------*----\n\n");
            /*
             * let the user enter the 3 points coordinates: (x1, y1) and (x2, y2) and (x3, y3),
             * To determine whether 3 points fall in the same line, you must calculate the slope between (x1, y1)&(x2, y2) and (x1, y1)&(x3, y3).
             * if the slopes are equal, then they fall in the same line.
             * slope between (x1, y1)&(x2, y2) = (y2-y1) / (x2-x1)
             */
            // CODE SNIPPET 6

            Console.Write("Enter x1:");
            float x1 = float.Parse(Console.ReadLine());
            Console.Write("Enter y1:");
            float y1 = float.Parse(Console.ReadLine());
            Console.Write("Enter x2:");
            float x2 = float.Parse(Console.ReadLine());
            Console.Write("Enter y2:");
            float y2 = float.Parse(Console.ReadLine());
            Console.Write("Enter x3:");
            float x3 = float.Parse(Console.ReadLine());
            Console.Write("Enter y3:");
            float y3 = float.Parse(Console.ReadLine());

            float slopeBetween1And2 = (y2 - y1) / (x2 - x1);
            float slopeBetween1And3 = (y3 - y1) / (x3 - x1);

            if (slopeBetween1And2 == slopeBetween1And3)
                Console.WriteLine("({0}, {1}) and ({2}, {3}) and ({4}, {5}) fall in the same line.", x1, y1, x2, y2, x3, y3);
            else
                Console.WriteLine("({0}, {1}) and ({2}, {3}) and ({4}, {5}) don't fall in the same line.", x1, y1, x2, y2, x3, y3);

            Console.WriteLine("\n\n----*--------*--------*--------*--------*----\n\n");
            Console.WriteLine("----*--------Exercise 6: Is it a leap or a normal year?--------*----\n\n");
            /*
             * let the user enter the year,
             * To determine whether a year is a leap year, follow the flowchart in the lab handout(pdf).   
             */
            // CODE SNIPPET 7.1
            // using nested if

            Console.WriteLine("Enter year:");
            int year = int.Parse(Console.ReadLine());

            if (year % 400 == 0)
                Console.WriteLine("{0} is a leap year.", year);
            else
            {
                if (year % 100 == 0)
                    Console.WriteLine("{0} is not a leap year.", year);
                else
                {
                    if (year % 4 == 0)
                        Console.WriteLine("{0} is a leap year.", year);
                    else
                        Console.WriteLine("{0} is not a leap year.", year);
                }
            }

            // CODE SNIPPET 7.2
            // using if-else-if 
            // this snippet is equivalent to the above.

            if (year % 400 == 0)
                Console.WriteLine("{0} is a leap year.", year);
            else if (year % 100 == 0)
                Console.WriteLine("{0} is not a leap year.", year);
            else if (year % 4 == 0)
                Console.WriteLine("{0} is a leap year.", year);
            else
                Console.WriteLine("{0} is not a leap year.", year);


            //CODE SNIPPET 7.3
            // using single if-else with complex condition
            // this snippet is equivalent to the above.

            if ((year % 100 != 0 && year % 4 == 0) || (year % 400 == 0))
                Console.WriteLine("{0} is a leap year.", year);
            else
                Console.WriteLine("{0} is not a leap year.", year);


            Console.WriteLine("\n\n----*--------*--------*--------*--------*----\n\n");
            Console.WriteLine("----*--------Exercise 7: Find my title--------*----\n\n");
            /*
             * let the user enter their gender and their age, then display their title (Mr. | Miss. | Mrs.)
             * follow the flowchart in the lab handout(pdf)
             */
            // CODE SNIPPET 8.1

            Console.Write("Enter your gender: (m for male | f for female)");
            char gender = char.Parse(Console.ReadLine());
            Console.Write("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            string title = "";             // assign the variable to avoid using unassigned local variable
            switch (gender)
            {
                case 'm':
                    title = "Mr.";
                    break;

                case 'f':
                    if (age <= 30)
                        title = "Miss.";
                    else
                        title = "Mrs.";
                    break;

                default:
                    Console.WriteLine("Invalid gender.");
                    break;
            }

            if (title != "")
                Console.WriteLine(title);

            // CODE SNIPPET 8.2

            Console.Write("Enter your gender: (m for male | f for female)");
            char gender2 = char.Parse(Console.ReadLine());


            string title2 = "";
            switch (gender2)
            {
                case 'm':
                    title2 = "Mr.";
                    break;

                case 'f':
                    Console.Write("Enter your age:");
                    int age2 = int.Parse(Console.ReadLine());          // only accept the age if the gender is female
                    if (age2 <= 30)
                        title2 = "Miss.";
                    else
                        title2 = "Mrs.";
                    break;

                default:
                    Console.WriteLine("Invalid gender.");
                    break;
            }

            if (title2 != "")
                Console.WriteLine(title2);

            Console.WriteLine("\n\n----*--------*--------*--------*--------*----\n\n");
            Console.WriteLine("----*--------Exercise 8: Calculate the fees of hotel--------*----\n\n");
            /*
             * let the user enter number of days you'll stay, and a month (May, June, July, August, September, October have special offers), and the type of room (studio, apartment)
             * (May or Oct)--> studio: 50$, apartment: 65$
             * (Jun or Sep)--> studio: 75$, apartment: 68$
             * (Jul or Aug)--> studio: 76$, apartment: 77$
             * the remaining months: 100$ for one day
             */
            // CODE SNIPPET 9

            Console.Write("Enter a number of days you'll stay:");
            int days = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the month (the first 3 letters):"); Console.WriteLine("(May or Oct)--> studio: 50$, apartment: 65$\n(Jun or Sep)--> studio: 75$, apartment: 68$\n(Jul or Aug)--> studio: 76$, apartment: 77$\nthe remaining months: 100$ for one day\n");
            string month = Console.ReadLine();
            Console.Write("Enter the type of room (s for studio, a for apartment):");
            char room = char.Parse(Console.ReadLine());

            int totalFees = 1;
            switch(month)
            {
                case "May":
                case "Oct":
                    switch(room)
                    {
                        case 's':
                            totalFees = 50 * days;
                            break;
                        case 'a':
                            totalFees = 65 * days;
                            break;
                    }
                    break;

                case "Jun":
                case "Sep":
                    switch (room)
                    {
                        case 's':
                            totalFees = 75 * days;
                            break;
                        case 'a':
                            totalFees = 68 * days;
                            break;
                    }
                    break;

                case "Jul":
                case "Aug":
                    switch (room)
                    {
                        case 's':
                            totalFees = 76 * days;
                            break;
                        case 'a':
                            totalFees = 77 * days;
                            break;
                    }
                    break;

                default:
                    switch (room)
                    {
                        case 's':
                            totalFees = 100 * days;
                            break;
                        case 'a':
                            totalFees = 150 * days;
                            break;
                    }
                    break;
            }

            Console.WriteLine("To stay {0} days, you'll pay {1}$", days, totalFees);
        }
    }
}
