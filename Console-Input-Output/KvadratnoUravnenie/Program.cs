using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratnoUravnenie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double D=b*b-4*a*c;
            if (D < 0)
            {
                Console.WriteLine("Nqma realni koreni");
            }
            else if (D == 0)
            {
                Console.WriteLine("Dvoen koren:");
                double x1 = -b  / (2 * a);
                Console.WriteLine(x1);
            }
            else
            {
                double x1 =( -b + Math.Sqrt(D)) / (2 * a);
                double x2 =( -b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine(x1);
                Console.WriteLine(x2);
                
            }
            Console.ReadLine();
        }
    }
}
