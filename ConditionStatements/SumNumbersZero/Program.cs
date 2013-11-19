using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbersZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int one =int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int four = int.Parse(Console.ReadLine());
            int five = int.Parse(Console.ReadLine());
            bool isZero = false;

            if (one + two == 0)
            {
                isZero = true;
            }
            else if (one + three == 0)
            {
                isZero = true;
            }
            else if (one + four == 0)
            {
                isZero = true;
            }
            else if (one + five == 0)
            {
                isZero = true;
            }
            else if (one + two + three == 0)
            {
                isZero = true;
            }
            else if (one + two + four == 0)
            {
                isZero = true;
            }
            else if (one + two + five == 0)
            {
                isZero = true;
            }
            else if (one + three + four == 0)
            {
                isZero = true;
            }
            else if (one + three + five == 0)
            {
                isZero = true;
            }
            else if (one + four + five == 0)
            {
                isZero = true;
            }
            else if (one + two + three + four == 0)
            {
                isZero = true;
            }
            else if (one + two + three + five == 0)
            {
                isZero = true;
            }
            else if (one + two + four + five == 0)
            {
                isZero = true;
            }
            else if (one + three + four + five == 0)
            {
                isZero = true;
            }
            else if (two + three + four + five == 0)
            {
                isZero = true;
            }
            else if (two + three == 0)
            {
                isZero = true;
            }
            else if (two + four == 0)
            {
                isZero = true;
            }
            else if (two + five == 0)
            {
                isZero = true;
            }
            else if (two + three + four == 0)
            {
                isZero = true;
            }
            else if (two + three + five == 0)
            {
                isZero = true;
            }
            else if (two + four + five == 0)
            {
                isZero = true;
            }
            else if (three + four == 0)
            {
                isZero = true;
            }
            else if (three + five == 0)
            {
                isZero = true;
            }
            else if (three + four + five == 0)
            {
                isZero = true;
            }
            else if (four + five == 0)
            {
                isZero = true;
            }
            else if (one + two + three + four + five == 0)
            {
                isZero = true;
            }
            if (isZero)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
