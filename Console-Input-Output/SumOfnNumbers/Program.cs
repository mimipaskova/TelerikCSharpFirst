using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfnNumbers
{
    class Program
    {
        //Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 



        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                sum += a;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
