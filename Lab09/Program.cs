using System;

namespace Lab09
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 5, num2 = 10;

            //int summation = SumOfTwoNumbers(num1, num2);  // SumOfTwoNumbers method calling 
            //Console.WriteLine("5 + 10 = "+summation);

            Console.WriteLine("----*----*----*----*----*----*----*----");

            //int greatest = FindTheGreatest(num1, num2);  // FindTheGreatest method calling
            //Console.WriteLine($"The greatest between {num1} & {num2} is {greatest}");

            //Console.WriteLine("----*----*----*----*----*----*----*----");

            //Print();     // Print method calling

            Console.WriteLine("----*----*----*----*----*----*----*----");

            //string myName = Console.ReadLine();
            //string sentence = Print2(myName);     // Print2 method calling
            //Console.WriteLine(sentence);

            Console.WriteLine("----*----*----*----*----*----*----*----");

            Console.WriteLine("----*----*----*----*----*----*----*----");

            string sentence2 = Print2();     // Print2 method calling
            Console.WriteLine(sentence2);

            Console.WriteLine("----*----*----*----*----*----*----*----");

            //int myNum = 30;
            //Console.WriteLine("Passing by value---Before applying method, myNum= {0}", myNum);
            //MultiplyBy10(myNum);    // MultiplyBy10 method calling
            //Console.WriteLine("Passing by value---After applying method, myNum= {0}", myNum);

            Console.WriteLine("----*----*----*----*----*----*----*----");

            //double myNum2 = 30.15;  // you must give the variable a value if you'll pass by ref
            //Console.WriteLine("Passing by ref---Before applying method, myNum= {0}", myNum2);
            //MultiplyBy10(ref myNum2);    // MultiplyBy10 method calling
            //Console.WriteLine("Passing by ref---After applying method, myNum= {0}", myNum2);

            Console.WriteLine("----*----*----*----*----*----*----*----");

            //int myNum3 ;  // you don't have to give the variable a value if you'll pass by out
            //MultiplyBy10(out myNum3);    // MultiplyBy10 method calling
            //Console.WriteLine("Passing by out---After applying method, myNum= {0}", myNum3);

            Console.WriteLine("----*----*----*----*----*----*----*----");

            //PrintNumbers(10);

            Console.WriteLine("----*----*----*----*----*----*----*----");

            //int m = int.Parse(Console.ReadLine());
            //int n = int.Parse(Console.ReadLine());
            //PrintNumbers(m, n);

            Console.WriteLine("----*----*----*----*----*----*----*----");

            //int sum = 0;
            //Console.WriteLine(SumTo_N(5, ref sum));
            //Console.WriteLine("----*----*----*----*----*----*----*----");

            //Console.WriteLine(Factorial(5));
        }

        // SumTo_N method definition
        static int SumTo_N(int n, ref int sum)
        {
            if (n > 0)
            {
                
                sum += n;
                n--;
                SumTo_N(n, ref sum);
            }
            return sum;
        }

        // PrintNumbers method (overloaded) definition
        static int PrintNumbers(int m, int n)
        {
            if (m > n)
                return 0;

            Console.WriteLine(m);
            m++;
            return PrintNumbers(m, n);
        }
        // PrintNumbers method definition
        static int PrintNumbers(int count)
        {
            if (count == 0)
                return 0;

            Console.WriteLine(count);
            count--;
            return PrintNumbers(count);
        }
        // MultiplyBy10 method (overloaded) definition
        static double MultiplyBy10(out int num)
        {
            num = 40;         // you must give the variable a value here
            num = num * 10;
            return num;
        }


        // MultiplyBy10 method (overloaded) definition
        static void MultiplyBy10(ref double num)
        {
            num = num * 10;
        }

        // MultiplyBy10 method definition
        static void MultiplyBy10(int num)
        {
            num = num * 10;
        }

        // Print2 method definition
        static string Print2()
        {
            string name = Console.ReadLine();
            string new_sentence = "Hello " + name;
            return new_sentence;
        }

        // Print2 method definition
        static string Print2(string name)
        { 
            string new_sentence = "Hello " + name;
            return new_sentence;
        }

        
        // Print method definition
        static void Print()
        {
            Console.WriteLine("Hello");
        }

        // FindTheGreatest method definition
        static int FindTheGreatest(int x, int y)
        {
            if (x > y)
                return x;
            else if (x < y)
                return y;
            else
                return 0;
        }

        // SumOfTwoNumbers method definition 
        static int SumOfTwoNumbers(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        
        static int Factorial (int i)
        {
            if (i == 0)
                return 1;
            int fact = i*Factorial(i-1);
            return fact;
        }

    }
}

