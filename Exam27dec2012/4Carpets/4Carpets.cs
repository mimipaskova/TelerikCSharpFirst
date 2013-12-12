using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _4Carpets
{
    class Program
    {
        static void Main(string[] args)
        {

            int M = int.Parse(Console.ReadLine());
            int N = M / 2;
           
                for (int j = 0; j < N; j++)
                {
                    for (int l = 0; l <=N-j-2; l++)
                    {
                        Console.Write(".");
                    }

                    for (int k = 0; k <= j/2; k++)
                    {
                        if (j % 2 == 0 )
                        {
                            if (k == j / 2)
                            {
                                Console.Write("/");
                            }
                            else
                            {
                                Console.Write("/");
                                Console.Write(" ");
                            }
                        }
                        else
                        {
                            Console.Write("/");
                            Console.Write(" ");
                        }
                    }
                    for (int k = 0; k <= j/2; k++)
                    {
                        if (j % 2 == 0)
                        {
                            if (k == j / 2)
                            {

                                Console.Write("\\");
                            }
                            else
                            {
                                Console.Write("\\");
                                Console.Write(" ");
                            }
                            // 
                        }
                        else
                        {
                            Console.Write(" ");
                            Console.Write("\\");
                            
                        }
                       
                       // Console.Write(" ");
                    }
                    
                    for (int l = 0; l <=N-j-2; l++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine();
                }


                for (int j = N-1; j >=0; j--)
                {
                    for (int l =0 ; l <=N-j-2; l++)
                    {
                        Console.Write(".");
                    }

                for (int k = 0; k <= j / 2; k++)
                {
                    if (j % 2 == 0)
                    {
                        if (k == j / 2)
                        {
                            Console.Write("\\");
                        }
                        else
                        {
                            Console.Write("\\");
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Write("\\");
                        Console.Write(" ");
                    }
                }
                for (int k = 0; k <= j / 2; k++)
                {
                    if (j % 2 == 0)
                    {
                        if (k == j / 2)
                        {

                            Console.Write("/");
                        }
                        else
                        {
                            Console.Write("/");
                            Console.Write(" ");
                        }
                        // 
                    }
                    else
                    {
                        Console.Write(" ");
                        Console.Write("/");

                    }

                    // Console.Write(" ");
                }


                for (int l = 0; l <= N - j - 2; l++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
                }            
        }
    }
}
