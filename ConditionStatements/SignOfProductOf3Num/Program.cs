﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOfProductOf3Num
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("0");
            }
             else if ((a > 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c < 0) || (a < 0 && b < 0 && c > 0))
            {
                Console.WriteLine("+");
            }
            else
                Console.WriteLine("-");
            Console.ReadLine();
        }
    }
}
