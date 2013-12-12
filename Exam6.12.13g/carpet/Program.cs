using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpet
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {

            }

            int width = N * 2;
            int height = 6 + ((N - 3) / 2) * 3;
            int sails = (2 * height) / 3;
            int Base = height / 3;

            for (int i = 0; i < width / 2; i++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            for (int i = 0; i < width / 2; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();


            for (int rows = 2; rows < sails; rows++)
            {
                for (int i = 0; i < width / 2 - (rows - 1); i++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int i = 0; i < width / 2 - (width / 2 - (rows - 2)); i++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int i = 0; i < width / 2 - (width / 2 - (rows - 2)); i++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int i = 0; i < width / 2 - (rows - 1); i++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }

            for (int k = 0; k < width + 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();



            for (int rows = 1; rows < Base; rows++)
            {
                for (int i = 0; i < rows; i++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int i = 0; i < width / 2 - 1 - rows; i++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int i = 0; i < width / 2 - 1 - rows; i++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int i = 0; i < rows; i++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();



            }

            for (int i = 0; i < (width - N) / 2 + 1; i++)
            {
                Console.Write(".");
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < (width - N) / 2 + 1; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();






        }
    }
}
