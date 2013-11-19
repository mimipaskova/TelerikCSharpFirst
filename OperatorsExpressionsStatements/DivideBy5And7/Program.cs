using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy5And7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 5 == 0 && number % 7 == 0)
            {
                Console.WriteLine("{0} se deli na 5 i 7", number);
            }
            else
            Console.WriteLine("Ne se deli na 5 i 7");
        }
    }
}
