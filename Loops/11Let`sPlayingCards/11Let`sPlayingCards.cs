using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Let_sPlayingCards
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int j = 1; j < 5; j++)
            {
                for (int i = 1; i < 14; i++)
                {
                    Console.WriteLine(" card {0}", i);

                    switch (j)
                    {

                        case 1: Console.Write("Spades"); break;
                        case 2: Console.Write("Hearts"); break;
                        case 3: Console.Write("Diomonds"); break;
                        case 4: Console.Write("Clubs"); break;

                    }

                }


            }
        }
    }
}
