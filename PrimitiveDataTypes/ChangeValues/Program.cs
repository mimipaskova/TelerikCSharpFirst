using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 5;
            int numberTwo = 10;
            int change;
            Console.WriteLine("Numbers are {0} and {1}", numberOne, numberTwo);
            change = numberOne;
            numberOne = numberTwo;
            numberTwo = change;
            Console.WriteLine("Numbers are {0} and {1}", numberOne, numberTwo);

            
        }
    }
}
