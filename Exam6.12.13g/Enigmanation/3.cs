using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigmanation
{
    class Program
    {
        static void Main(string[] args)
        {

            string izraz = Console.ReadLine();
            int promenliva = izraz[0];

            for (int i = 0; i < izraz.Length; i++)
            {
                if (izraz[i].Equals('('))
                {
                    if (izraz[i + 2].Equals('+'))
                    {
                        promenliva = izraz[i + 1] + izraz[i + 3];
                    }
                    if (izraz[i + 2].Equals('-'))
                    {
                        promenliva = izraz[i + 1] - izraz[i + 3];
                    }
                    if (izraz[i + 2].Equals('*'))
                    {
                        promenliva = izraz[i + 1] * izraz[i + 3];
                    }
                    if (izraz[i + 2].Equals('%'))
                    {
                        promenliva = izraz[i + 1] % izraz[i + 3];
                    }
                    i = i + 4;
                }
                int[] numbers = new int[10];
                for (int j = 0; j < numbers.Length; j++)
                {
                    numbers[j] = j;
                    if (izraz[i].Equals(numbers[j]))
                    {

                    }
                }




            }
        }
    }
}
