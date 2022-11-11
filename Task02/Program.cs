using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * This program is to let the user enter salary
             * and then calculate the net salart after applying the tax of 10,
             * then show them the before and after.
             */


            Console.Write("Please, enter the salary:");        // just to inform the user what they are going to enter
            float salary = float.Parse(Console.ReadLine());    // it's recommended to store salary in float as user can enter floating-point number.
            float netSalary = salary - (salary * 0.1f);        // it's equivalent to --->   float netSalary = salary * 0.9f;

            Console.WriteLine("The salary before applying the tax = {0}", salary);
            Console.WriteLine("The salary after applying the tax = {0}", netSalary);
        }
    }
}
