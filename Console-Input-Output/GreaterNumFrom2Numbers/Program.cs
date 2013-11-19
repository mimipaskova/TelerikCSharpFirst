using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumFrom2Numbers
{
    class Program
    {
        //Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());           
            Console.WriteLine(Math.Max(a, b));
            Console.ReadLine();
        }
    }
}
