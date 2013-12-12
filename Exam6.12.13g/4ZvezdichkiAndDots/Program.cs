using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4ZvezdichkiAndDots
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int j = 0; j < N; j++)
                {
                    for (int l = 0; l <=N-j-1; l++)
                    {
                        Console.Write(".");
                    }
                   

                    for (int l = 0; l <j/2+1 ; l++)
                    {
                        Console.Write("*");
                                
                                //for (int i = 0; i < 2*j+1; i++)
                                //{
                                    
                                //}
                    }
                    for (int l = 0; l <= N - j - 1; l++)
                    {
                        Console.Write(".");
                       
                    }
                    Console.WriteLine();

                    
                }

        }
    }
}
