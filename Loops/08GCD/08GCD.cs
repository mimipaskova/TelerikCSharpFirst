using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            while (numberOne != numberTwo)
            {

                if (numberOne > numberTwo)
                {
                    numberOne = numberOne - numberTwo;
                }
                else
                {
                    numberTwo = numberTwo - numberOne;
                   
                }
                
            }
            Console.WriteLine(numberOne);
        }
    }
}
