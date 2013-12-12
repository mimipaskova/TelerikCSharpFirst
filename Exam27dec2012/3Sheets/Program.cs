using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Sheets
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] masiv=new int[11];
            int sheets=0;
            for (int i = 10; i >= 0; i--)
			{
                masiv[i] =(int) Math.Pow(2.0, (double)(10 - i));			 
			}

            for (int i = 0; i <11; i++)
            {
                if (sheets + masiv[i] <= N)
                {
                    sheets += masiv[i];
                    masiv[i] = -1;
                }

            }
            for (int i =10; i >=0; i--)
            {
                if (masiv[i] != -1)
                {
                    Console.WriteLine("A{0}",i);
                }
            }

        }
    }
}
