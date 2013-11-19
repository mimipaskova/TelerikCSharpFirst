using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Sort3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());

                if (a > b && b > c)
                {
                    Console.WriteLine("Numbers are {0}, {1}, {2}", a, b, c);
                }
                else if (a > b)
                {
                    if (a > c && c > b)
                    {
                        Console.WriteLine("Numbers are {0}, {1}, {2}", a, c, b);
                    }
                    else
                    {
                        Console.WriteLine("Numbers are {0}, {1}, {2}", c, a, b);
                    }
                }
                else if (b > a)
                {
                    if (a > c)
                    {
                        Console.WriteLine("Numbers are {0}, {1}, {2}", b, a, c);
                    }
                    else
                    {
                        Console.WriteLine("Numbers are {0}, {1}, {2}", c, b, a);
                    }
                }
                else if (b < c && c < a)
                {

                    Console.WriteLine("Numbers are {0}, {1}, {2}", b, c, a);
                }
            }
        }


    }
}
