using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaleFemale
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isFemale=false;
            char a=char.Parse(Console.ReadLine());
            if (a == 'm')
            {
                Console.WriteLine("Male");
                Console.WriteLine(isFemale);
            }
            else
            {
                isFemale = true;
                Console.WriteLine("Female");
                Console.WriteLine(isFemale);
            }
        }
    }
}
