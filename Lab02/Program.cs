using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             This is a multi-line comment
             I wrote to illustrate the concept of
             multi-line comment
            */

            // But this is a single line comment

            /*-------------------------------------*/

            string name; // 1- Declaration of variable called name
            name = "Reham";   // 2- Assignment (we assigned the value "Reham" to the variable name)
            
            // The previous 1 & 2 lines can be joined using initialization statement (the next comment)
            // string name= "Reham";
            
            Console.WriteLine(name);     // This will print out: Reham
            
            Console.WriteLine();
            Console.WriteLine("=====================================");
            Console.WriteLine();

            Console.WriteLine("Int type ranges from {0} to {1}", int.MinValue, int.MaxValue);   // This will show you the range of certain data type

            Console.WriteLine();
            Console.WriteLine("=====================================");
            Console.WriteLine();

            
            int hex = 0xFace;         // Hexa-decimal form literal
            int bin = 0b101;          // binary-form literal                        
            int oct = 0145;             // octal-form literal

            Console.WriteLine("Face Converted to Hexa format: {0}", hex);
            Console.WriteLine("101 Converted to Binary format: {0}", bin);
            Console.WriteLine("145 Converted to Octal format: {0}", oct);

            Console.WriteLine();
            Console.WriteLine("=====================================");
            Console.WriteLine();

            

            int x = 10, y = 55;
            Console.WriteLine("The value of x = "+x);             // This will print out: The value of x = 10
            Console.WriteLine("The value of y = "+y);             // This will print out: The value of y = 55

            int sum = x + y;
            Console.WriteLine("The value of x + y = " + sum);          // This will print out: The value of x + y = 65
            Console.WriteLine("The value of {0} + {1} = {2}", x, y, sum);          // This will print out: The value of 10 + 55 = 65

            int subtract = x - y;
            Console.WriteLine("The value of x + y = " + subtract);          // This will print out: The value of x - y = -45
            Console.WriteLine("The value of {0} - {1} = {2}", x, y, subtract);          // This will print out: The value of 10 - 55 = -45


            Console.WriteLine();
            Console.WriteLine("=====================================");
            Console.WriteLine();

            //Console.Write("Enter one character: ");
            //char myChar= Convert.ToChar(Console.Read());        // It reads one character and returns its unicodeb(int)

            //Console.WriteLine("You entered "+myChar);

            Console.WriteLine();
            Console.WriteLine("=====================================");
            Console.WriteLine();

            Console.Write("Enter what you need: ");
            string myString = Console.ReadLine();        // It reads any number of characters and returns a string

            Console.WriteLine("You entered " + myString);

            Console.WriteLine();
            Console.WriteLine("=====================================");
            Console.WriteLine();

            /* Now we'll write a program to accept Fahrenheit temperature from the user and convert it into its equivalent in Celsius. */

            Console.Write("Enter fahrenheit temperature: ");
            double fahrenheit = double.Parse(Console.ReadLine());          // You must convert the input to double
            double celsius = (5 / 9)*(fahrenheit - 32);
            Console.WriteLine("The equivalent in Celsius = {0}", celsius);


            Console.WriteLine();
            Console.WriteLine("=====================================");
            Console.WriteLine();

            /* Now we'll write a program to accept raduis of circle from the user and calculate its area and perimeter. */

            Console.Write("Enter circle raduis: ");
            int raduis = int.Parse(Console.ReadLine());     // You must convert the input to int
            const float pi = 3.14F;                          // You must add F suffix to define a float variable
            float area = pi * raduis * raduis;              // This line is equivelent to (double area = (Math.PI) * (Math.Pow(raduis, 2));)
            double perimeter = 2 * Math.PI * raduis;
            
            Console.WriteLine("The area = {0}", area);
            Console.WriteLine("The perimeter = {0}", perimeter);

            
            Console.ReadKey();          // This line expects the user will enter a key to continue
        }
    }
}
