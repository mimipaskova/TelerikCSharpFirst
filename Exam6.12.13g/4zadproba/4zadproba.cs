using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4zadproba
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int p = 0; p < N; p++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            for (int p = 0; p < N; p++)
            {
                Console.Write(".");
            }
            Console.WriteLine();

           
            //vtori red
                for (int j = 1; j < 2; j++)
                {
                    for (int i = N - j; i > 0; i--)
                    {
                        Console.Write(".");
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        
                        Console.Write("*");
                       
                    }
                    for (int i = N - j; i > 0; i--)
                    {
                        Console.Write(".");
                    }
                   
                    Console.WriteLine();
                }

                for (int j = 2; j < N-1; j++)
                {
                    for (int i = N - j; i > 0; i--)
                    {
                        Console.Write(".");
                        
                    }
                    for (int i = 0; i < 3; i++)
                    {

                        Console.Write("*");
                        for (int k = 0; k < N-3; k++)
                        {
                            Console.Write(".");
                        }
                       

                    }
                    for (int i = N - j; i > 0; i--)
                    {
                        Console.Write(".");
                    }
                    

                    Console.WriteLine();
                }


                //for (int q = 0; q < 1; q++)
                //{

                //    Console.Write(".");
                //    Console.Write("*");
                //    Console.Write(".");
                //    Console.Write("*");
                //    Console.Write(".");
                //    Console.Write("*");
                //    Console.Write(".");
                //}
                //Console.WriteLine();

                //for (int r = 0; r < 1; r++)
                //{
                //    for (int i = 0; i < 2*N+1; i++)
                //    {
                //        Console.Write("*");
                //    }
                //}
                //Console.WriteLine();
                //for (int q = 0; q < 1; q++)
                //{

                //    Console.Write(".");
                //    Console.Write("*");
                //    Console.Write(".");
                //    Console.Write("*");
                //    Console.Write(".");
                //    Console.Write("*");
                //    Console.Write(".");
                //}
                //Console.WriteLine();

                //for (int j = 1; j < N - 1; j++)
                //{
                //    for (int i = N - 1; i > 0; i--)
                //    {
                //        Console.Write(".");
                //    }
                //    for (int i = 0; i < 3; i++)
                //    {
                //        Console.Write("*");
                //    }
                //    for (int i = N - 1; i > 0; i--)
                //    {
                //        Console.Write(".");
                //    }
                //    Console.WriteLine();
                //}

            


        }
    }
}
