using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03MinMaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int min=Int32.MaxValue, max=Int32.MinValue;
            for (int i = 0; i < N; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }
                if(number<min)
                {
                    min = number;
                }
            }
            Console.WriteLine("Min number is {0} Max number is {1}", min, max);
        }
    }
}
