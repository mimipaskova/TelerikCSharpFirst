using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6KvadratnoUravnenie
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double x1, x2;

            double D = b * b - 4 * a * c;
            if (D == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("Root one = root two = {0}", x1);
            }
            else if (D < 0)
            {
                Console.WriteLine("No real roots");
            }

            else
            {
                x1 = (-b + Math.Sqrt(D)) / 2 * a;
                x2 = (-b - Math.Sqrt(D)) / 2 * a;
                Console.WriteLine("Roots are {0} and {1}", x1, x2);
            }
        }
    }
}
