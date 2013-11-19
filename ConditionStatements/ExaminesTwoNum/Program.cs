using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminesTwoNum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = 0;

            if (a > b)
            {
                c = a;
                a = b;
                b = c;
            }
            Console.WriteLine("Num are {0}, {1}",a,b);
            Console.ReadLine();
        }
    }
}
