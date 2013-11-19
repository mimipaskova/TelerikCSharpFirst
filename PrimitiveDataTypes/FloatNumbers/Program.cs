using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            float number1 = float.Parse(Console.ReadLine());           
            float number2 = float.Parse(Console.ReadLine());

            Console.WriteLine("The two numbers are: {0} and {1}", number1, number2);

            if (number1 == number2)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
