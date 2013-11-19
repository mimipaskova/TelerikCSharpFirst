using System;

namespace Sum3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads 3 integer numbers from the console and prints their sum.

            double a=double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine()); 
            double sum;
            sum = a + b + c;
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
