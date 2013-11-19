using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool flag = false;
                int number = int.Parse(Console.ReadLine());
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i != 0)
                    {
                        flag = false;
                  
                    }
                    else
                    {
                        flag = true;
                        Console.WriteLine("NOT Prime");
                        break;
                    }
                }
                if (!flag)
                    Console.WriteLine("Prime");
            }

        }
    }
}

