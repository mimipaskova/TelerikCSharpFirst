using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersBetween2Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int br = 0;
            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    if ((i % 5) == 0)
                    {
                        br++;
                    }
                }
                Console.WriteLine(br);
                Console.ReadLine();
            }
            else
            {
                for (int i = b; i <= a; i++)
                {
                    if ((i % 5) == 0)
                    {
                        br++;
                    }
                }
                Console.WriteLine(br);
                Console.ReadLine();
            }
        }
    }
}
