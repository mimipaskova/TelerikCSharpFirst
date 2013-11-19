using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int N = int.Parse(Console.ReadLine());
                int S = 3;
                int firstNum = 0;
                int secNum = 1;
                int number = firstNum + secNum;

                for (int i = 3; i < N; i++)
                {
                    firstNum = secNum;
                    secNum = number;
                    number = firstNum + secNum;
                    S = S + number;
                }
                Console.WriteLine(S);
            }
        }
    }
}
