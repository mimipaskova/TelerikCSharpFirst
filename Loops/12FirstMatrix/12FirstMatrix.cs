using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12FirstMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n+1; i++)
            {
                for (int j = i; j < i+n; j++)
                {
                    Console.Write(" "+j);
                }
                Console.WriteLine();
                
            }
        }
    }
}
