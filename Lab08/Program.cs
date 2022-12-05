using System;

namespace Lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----*--------*--------General notes on loops--------*--------*----");

            Console.WriteLine("----*--------*--------Note #1--------*--------*----");
            // note #1
            // notice the difference between the following loops:
            // 1.1
            //for(int i= 0; i<5; i++)
            //{
            //    // this 3 statements will be printed 5 times
            //    Console.WriteLine("This is the first statement.");       
            //    Console.WriteLine("This is the second statement.");      
            //    Console.WriteLine("This is the third statement.");       
            //}
            Console.WriteLine("----*--------*--------*--------*--------*--------*----");

            //1.2
            //for (int i = 0; i < 5; i++)

            //    Console.WriteLine("This is the first statement.");       // this will printed be 5 times
            //    Console.WriteLine("This is the second statement.");      // this will printed be 1 time
            //    Console.WriteLine("This is the third statement.");       // this will printed be 1 time

            Console.WriteLine("----*--------*--------*--------*--------*--------*----");



            //1.3
            //for (int i = 0; i < 5; i++)
            //    for(int j=0; j<3; j++)
            //    {
            //        Console.WriteLine("This is a statement.");       // this will be printed 15 times
            //    }
            //Console.WriteLine("This is an outer statement.");        // this will be printed 1 time

            //Console.WriteLine("----*--------*--------*--------*--------*--------*----");

            Console.WriteLine("----*--------*--------Note #2--------*--------*----");
            // note #2
            // notice the difference between the following loops:
            // 2.1
            //int i = 0;
            //while (i < 4)
            //{ 
            //    Console.WriteLine("iii");
            //    Console.WriteLine("rrr");
            //    i++;
            //}
            Console.WriteLine("----*--------*--------*--------*--------*--------*----");

            //// 2.2
            //while (i < 4)
            //    Console.WriteLine("iii");        // this will be printed infinite times
            //    Console.WriteLine("rrr");
            //    i++;


            Console.WriteLine("----*--------*--------*--------*--------*--------*----");

            Console.WriteLine("----*--------*--------Note #3--------*--------*----");
            // note #3
            //// 3.1
            //for (int i = 0; i < 5; i++) ;
            //{
            //    Console.WriteLine("Hello");
            //    Console.WriteLine("red");
            //}


            Console.WriteLine("----*--------*--------*--------*--------*--------*----");

            //// 3.2
            //for (int i = 0; i < 5; i++) ;
            //{
            //    Console.WriteLine(i);       // this will throw an error because i is local to for loop which is canceled by the ;
            //    Console.WriteLine("red");
            //}

            Console.WriteLine("----*--------*--------*--------*--------*--------*----");

            //// 3.3
            //int i = 0;
            //while (i < 10) ;               // this ; will freeze the program
            //{
            //    Console.WriteLine("iii");         // this will not be executed
            //    i++;
            //}
            //Console.WriteLine("iii");    // this will not be executed

            Console.WriteLine("----*--------*--------*--------*--------*--------*----");

            Console.WriteLine("----*--------*--------Note #4--------*--------*----");
            // note #4
            //// 4.1
            //int i = 1;
            //for (; i <= 60; i *= 2)     // this is  valid
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("After breaking the loop, i= " + i);        // i = 64 at the end of this loop

            Console.WriteLine("----*--------*--------*--------*--------*--------*----");

            //// 4.2
            //int i = 1;
            //for (i = 6; i <= 60; i *= 2)     // this is valid, this reassigns i to 6 instead of 1
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("After breaking the loop, i= " + i);        // i = 96 at the end of this loop

            Console.WriteLine("----*--------*--------*--------*--------*--------*----");

            //// 4.3
            //int i = 1;
            //for (i; i <= 60; i *= 2)     // this is not valid
            //{
            //    Console.WriteLine(i);
            //}

            Console.WriteLine("----*--------*--------*--------*--------*--------*----");
            Console.WriteLine("----*--------*--------*--------*--------*--------*----");
            Console.WriteLine("----*--------*--------Exercises--------*--------*----");

            /****************** continue and break ******************/

            Console.WriteLine("----*--------*--------*--------*--------*--------*----");
            Console.WriteLine("----*--------*--------Exercise #1--------*--------*----");
            //exercise #1

            // 1.1 using for loop

            //Console.WriteLine("This loop will print numbers from 1 to 10, except 7");
            //for (int i = 9; i <= 10; i++)
            //{
            //    if (i == 7)
            //        continue;                        // skip only number 7, go to next iteration
            //    Console.WriteLine(i);
            //}

            Console.WriteLine("----*--------*--------*--------*--------*--------*----");

            // 1.2 using while loop

            //Console.WriteLine("This loop will print numbers from 1 to 10, except 7");
            //int count = 1;
            //while(count<=10)
            //{
            //    if(count==7)
            //    {
            //        count++;
            //        continue;
            //    }
            //    Console.WriteLine(count);
            //    count++;
            //}

            Console.WriteLine("----*--------*--------*--------*--------*--------*----");

            Console.WriteLine("----*--------*--------Exercise #2--------*--------*----");
            //exercise #2

            //Console.WriteLine("This loop is to print numbers from 1 to 10, but it will stop when it reaches 7");
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 7)
            //        break;                      // when you reach 7, exit the whole loop completely
            //    Console.WriteLine(i);
            //}

            Console.WriteLine("----*--------*--------*--------*--------*--------*----");

            Console.WriteLine("----*--------*--------Exercise #3--------*--------*----");
            //exercise #3

            //Console.WriteLine("This loop will print 'skip' with numbers 3, 4, 5, 6");
            //for (int i = 0; i < 15; i++)
            //{
            //    Console.Write($"Iteration {i}: ");

            //    if (i >= 3 && i < 7)
            //    {
            //        Console.WriteLine("skip");
            //        continue;
            //    }

            //    Console.WriteLine("done");
            //    }


            Console.WriteLine("----*--------*--------*--------*--------*--------*----");

            Console.WriteLine("----*--------*--------Exercise #4--------*--------*----");
            //exercise #4

            //Console.WriteLine("If you reach letter y, the rest of letters will not be displayed.");
            //Console.WriteLine("Enter any words:");
            //string words = Console.ReadLine();

            //foreach (char character in words)      // foreah is special case from for loop to iterate over an array or a string.      wordsالسطر دا معناه امشي على كل حرف في الكلام المتخزن في المتغير
            //{
            //    if (character == 'y')
            //        break;
            //    Console.WriteLine(character);
            //}

            Console.WriteLine("----*--------*--------*--------*--------*--------*----");

            Console.WriteLine("----*--------*--------Exercise #5--------*--------*----");
            //exercise #5 ----> مش معانا، للمعرفة بس goto

            //Console.WriteLine("goto example");
            //Console.WriteLine("Enter any words:");
            //int number = 20;
            //switch (number)
            //{

            //    case 5:
            //        Console.WriteLine("case 5");
            //        break;
            //    case 10:
            //        Console.WriteLine("case 10");
            //        break;
            //    case 20:
            //        Console.WriteLine("case 20");

            //        // goto statement transfer the control to case 5
            //        goto case 5;

            //    default:
            //        Console.WriteLine("No match found");
            //        break;
            //}

            Console.WriteLine("----*--------*--------*--------*--------*--------*----");

            Console.WriteLine("----*--------*--------Exercise #6--------*--------*----");
            //exercise #6

            //// 6.1
            ///
            //while (true)
            //{
            //    // This statement will be printed infinite times
            //    Console.WriteLine("Infinite loop");
            //}

            Console.WriteLine("----*--------*--------*--------*--------*--------*----");

            //// 6.2
            ///
            //for(; ; )
            //{
            //    Console.WriteLine("Infinite loop");
            //}
            Console.WriteLine("----*--------*--------*--------*--------*--------*----");

            ///// 6.3
            ///
            //for(int i=0; i<10 ; )
            //{
            //    Console.WriteLine("Infinite loop");
            //}


            Console.WriteLine("----*--------*--------*--------*--------*--------*----");
            Console.WriteLine("----*--------*--------*--------*--------*--------*----");
            


            /************** Nested loops **************/

Console.WriteLine("----*--------*--------*--------*--------*--------*----");
            Console.WriteLine("----*--------*--------Exercise #7--------*--------*----");
            //exercise #7

            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine("----------------------This is the outer iteration #{0}----------------------" , i);

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine("This is the inner iteration #" + j);
            //    }
            //}

            Console.WriteLine("----*--------*--------*--------*--------*--------*----");
            Console.WriteLine("----*--------*--------Exercise #8: Number of iterations--------*--------*----");
            //exercise #8

            //int outerLoop = 0, innerLoop = 0;       // two variables to track number of iterations in each loop
            //for (int i = 1; i <= 5; i++)
            //{
            //    outerLoop++;        // this will be increased by one each time the outer loop runs

            //    for (int j = 1; j <= 5; j++)
            //    {
            //        innerLoop++;         // this will be increased by one each time the inner loop runs, this counts the total number of runs
            //    }
            //}
            //Console.WriteLine("Outer Loop runs {0} times", outerLoop);
            //Console.WriteLine("Inner Loop runs {0} times totally", innerLoop);


            Console.WriteLine("----*--------*--------*--------*--------*--------*----");
            Console.WriteLine("----*--------*--------Exercise #9: Number of iterations--------*--------*----");
            //exercise #9

            //int outerLoop = 0, innerLoop = 0;       // two variables to track number of iterations in each loop
            //for (int i = 1; i <= 5; i++)
            //{
            //    outerLoop++;        // this will be increased by one each time the outer loop runs

            //    innerLoop = 0;           // this allow to count only the number of iterations of inner loop during one iteration of outer loop
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        innerLoop++;         // this will be increased by one each time the inner loop runs
            //    }
            //}
            //Console.WriteLine("Outer Loop runs {0} times", outerLoop);
            //Console.WriteLine("Inner Loop runs {0} times each time outer loop runs", innerLoop);

            Console.WriteLine("----*--------*--------*--------*--------*--------*----");
            Console.WriteLine("----*--------*--------Exercise #10: Triangle of numbers--------*--------*----");
            //exercise #10

            //for (int outer = 0; outer < 5; outer++)
            //{  
            //    for (int inner = 0; inner < 5; inner++)
            //    {
            //        if (inner > outer)
            //        {
            //            break;
            //        }

            //        Console.Write($"{inner} ");
            //    }
            // }   


            Console.WriteLine("----*--------*--------*--------*--------*--------*----");
            Console.WriteLine("----*--------*--------Exercise #11: Triangle of numbers--------*--------*----");
            //exercise #11

            //int i = 1;
            //while (i <= 5)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i + " ");
            //    }

            //    Console.WriteLine();
            //    i++;
            //}

            Console.WriteLine("----*--------*--------*--------*--------*--------*----");
            Console.WriteLine("----*--------*--------Exercise #12: Prime numbers from 1 to 100--------*--------*----");
            //exercise #12

            for (int i = 2; i < 100; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    if ((i % j) == 0)
                    {
                        //Console.WriteLine(i);
                        isPrime = false;     // if factor found, not prime
                        break;
                    }
                }
                if (isPrime)
                    Console.WriteLine("{0} is prime", i);
            }


            Console.WriteLine("----*--------*--------*--------*--------*--------*----");
            Console.WriteLine("----*--------*--------Exercise #13: Find the biggest number--------*--------*----");
            //exercise #13

            //Console.WriteLine("enter any numbers to find the greatest, if you want to stop enter 0:");
            //int num = int.Parse(Console.ReadLine());
            //int greatest = num;
            //while(num!=0)
            //{
            //     num = int.Parse(Console.ReadLine());
            //    if (num > greatest)
            //        greatest = num;
            //}

            //Console.WriteLine("The greatest number is "+greatest);

            Console.WriteLine("----*--------*--------*--------*--------*--------*----");
            Console.WriteLine("----*--------*--------Exercise #14: Extract string--------*--------*----");
            //exercise #14

            //Console.WriteLine("Write any chararters separated by !");
            //string anyWords = Console.ReadLine();
            //string extractedWord = "";
            //foreach(char character in anyWords)
            //{

            //    if (character != '!')
            //    { 
            //        extractedWord += character;
            //    }
            //}

            //Console.WriteLine(extractedWord);

            Console.WriteLine("----*--------*--------*--------*--------*--------*----");
            Console.WriteLine("----*--------*--------Exercise #15: Splice string--------*--------*----");
            //exercise #15

            //Console.WriteLine("Write any sentence");
            //string sentence = Console.ReadLine();

            //for(int i=0; i<sentence.Length; i++)
            //{
            //    if(sentence[i] ==  ' ')
            //        Console.WriteLine();
            //    else
            //        Console.Write(sentence[i]);
            //}


            Console.WriteLine("----*--------*--------Printing shapes--------*--------*----");
            Console.WriteLine();
            //Console.WriteLine("----*--------*--------Shape #1--------*--------*----");
            //Console.WriteLine();
            ////exercise #16
            ///
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            Console.WriteLine();
            //Console.WriteLine("----*--------*--------Shape #2--------*--------*----");
            //Console.WriteLine();
            ////exercise #17.1
            ///
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= (5 - i); j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //Console.WriteLine();
            ////exercise #17.1        this is equivalent to exercise #17.1

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 4; j >= i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 4; j > 4-i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("----*--------*--------Shape #3--------*--------*----");
            //Console.WriteLine();
            ////exercise #18

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 6-i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //Console.WriteLine("----*--------*--------Shape #4--------*--------*----");
            //Console.WriteLine();
            ////exercise #19

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 5; j > 6 - i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 5; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //Console.WriteLine("----*--------*--------Shape #5--------*--------*----");
            //Console.WriteLine();
            ////exercise #20 

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int k = 1; k < i; k++)
            //        Console.Write(" ");

            //    for (int j = i; j <= 5; j++)
            //        Console.Write("* ");

            //    Console.WriteLine();
            //}

            //Console.WriteLine("----*--------*--------Shape #6--------*--------*----");
            //Console.WriteLine();
            ////exercise #21

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int k = 1; k < i; k++)
            //        Console.Write(" ");

            //    for (int j = i; j <= 5; j++)
            //        Console.Write("* ");

            //    Console.WriteLine();
            //}


            //Console.WriteLine("----*--------*--------Shape #7--------*--------*----");
            //Console.WriteLine();
            ////exercise #22

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int k = 1; k < i; k++)
            //        Console.Write(" ");

            //    for (int j = i; j <= 5; j++)
            //        Console.Write("* ");

            //    Console.WriteLine();
            //}
         
            //for (int i = 5 - 1; i >= 1; i--)
            //{
            //  for (int k = 1; k < i; k++)
            //        Console.Write(" ");

            //  for (int j = i; j <= 5; j++)
            //    Console.Write("* ");

            //    Console.WriteLine();
            //}
        }
    }
}
