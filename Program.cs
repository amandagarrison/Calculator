using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("A Consonle Calculator");
           
            Console.WriteLine("Enter a number.");
            num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter a second number and I will add it to the first");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result: " + (num1 + num2));
        }
    }
}
