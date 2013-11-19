using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           // S = 1 + 1!/X + 2!/X2 + … + N!/XN

            int N = int.Parse(Console.ReadLine());
            int X = int.Parse(Console.ReadLine());
            double S = 0;
            int chislitel=1;
            double znamenatel=1;
            
            for (int i = 1; i < N+1; i++)
            {
                chislitel=chislitel*i;
                znamenatel=Math.Pow((int)X,(int)i);
                S = S + (double)chislitel / znamenatel;
                Console.WriteLine(S);
            }

            Console.WriteLine(S);

        }
    }
}
