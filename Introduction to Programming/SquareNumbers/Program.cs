using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double number;
            int pow;
            number=double.Parse( Console.ReadLine());
            pow = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(number, pow));
            Console.ReadLine();
        }
    }
}
