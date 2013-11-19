using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbers1_n
{
    class Program
    {
        //Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
