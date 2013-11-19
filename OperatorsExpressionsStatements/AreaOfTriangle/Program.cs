using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());
            Console.WriteLine("Area is {0}", width * heigth);
        }
    }
}
