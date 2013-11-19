using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiggestOf3Num
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the biggest of three integers using nested if statements.

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.Write("The biggest is");
            if (a > b)
            {
                if (a > c)
                { Console.WriteLine(a); }
                else
                {
                    Console.WriteLine(c);
                }
            }
            else if
                (b < c)
            { 
                Console.WriteLine(c); 
            }
            else
            {
                Console.WriteLine(b);
            }
            Console.ReadLine();
        }
    }
}
