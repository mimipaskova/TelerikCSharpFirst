using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Tribonacci
{
    class Program
    {

        static void Main(string[] args)
        {

            Int64[] masiv = new Int64[10000];
            masiv[0] = Int64.Parse(Console.ReadLine()); ;
            masiv[1] = Int64.Parse(Console.ReadLine()); ;
            masiv[2] = Int64.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            if (N > 1 && N < 21)
            {
                Int64 number = masiv[0] + masiv[1] + masiv[2];

                //  Console.WriteLine(masiv[0]);
                //Console.WriteLine(masiv[1]+ " "+ masiv[2]);
                for (int i = 3; i < masiv.Length; i++)
                {
                    masiv[i] = masiv[i - 3] + masiv[i - 2] + masiv[i - 1];


                }
                //for (int i = 0; i < N; i++)
                //{
                //    Console.Write(masiv[i] + " ");

                //}
                int br1 = 0;

                for (int i = 0; i < N; i++)
                {
                    int br = i;
                    for (int j = 0; j <= i; j++)
                    {

                        Console.Write(masiv[br1] + " ");
                        br++;
                        br1++;
                    }
                    Console.WriteLine();

                }
            }
            

        }
    }
}
