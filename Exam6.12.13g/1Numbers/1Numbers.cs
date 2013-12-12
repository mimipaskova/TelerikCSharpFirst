using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
             Int64 A = Int64.Parse(Console.ReadLine());
            Int64 B = Int64.Parse(Console.ReadLine());
            Int64 C = Int64.Parse(Console.ReadLine());
            Int64 result = 0;
            Int64 remind = 1;

            if (A <= 999999 && C <= 999999 && B < 999999 && A >= 1 && B >= 1 && C >= 1)
            {


                if (B == 2)
                {
                    result = A % C;
                }
                else if (B == 4)
                {
                    result = A + C;
                }
                else if (B == 8)
                {
                    result = A * C;
                }

                if (result % 4 == 0)
                {
                    remind = result / 4;                    
                    Console.WriteLine(remind);
                }
                else
                {
                    Console.WriteLine(result % 4);
                }
                Console.WriteLine(result);

            }
            else
            {
               
            }
        }
    }
}
