using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";
            object merge = str1 + " " + str2;
            string merging = (string)merge;
            Console.WriteLine(merging);

           
        }
    }
}
