using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimeturAndAreaCirle
{
    
    class Program
    {
        //Write a program that reads the radius r of a circle and prints its perimeter and area.

        static void Main(string[] args)
        {
            double pi=Math.PI;
            double r = double.Parse(Console.ReadLine());
            double per = 2 * r * pi;
            double area = pi * r * r;
            Console.WriteLine(per);
            Console.WriteLine(area);
            Console.ReadLine();
        }
    }
}
