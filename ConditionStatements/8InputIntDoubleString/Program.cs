using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8InputIntDoubleString
{
    class Program
    {
        static void Main(string[] args)
        {
            byte input = byte.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    int intInput = int.Parse(Console.ReadLine());
                    Console.WriteLine(intInput + 1);
                    break;
                case 2:
                    double doubleInput = double.Parse(Console.ReadLine());
                    Console.WriteLine(doubleInput + 1);
                    break;
                case 3:
                    string stringInput = Console.ReadLine();
                    Console.WriteLine(stringInput+ '*');
                    break;
                default:
                    break;
            }
        }
    }
}
