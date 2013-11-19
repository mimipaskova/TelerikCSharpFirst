using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_0_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int area = x * x + y * y;
            if (area <= 25)
            {
                Console.WriteLine("vutreshna e");
            }
            else
                Console.WriteLine("vunshna e");
        }
    }
}
