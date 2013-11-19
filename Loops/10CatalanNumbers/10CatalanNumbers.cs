using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10CatalanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int NFack = 1,NZnam=1;
            int znamenatel = 1;           
            for (int i = 1; i <= 2*N; i++)
            {
                NFack = NFack * i;
            }
            for (int i = 1; i <= N+1; i++)
            {
                NZnam = NZnam * i;
            }

            for (int i = 1; i <=  N; i++)
            {
                znamenatel = znamenatel * i;
            }
          //  Console.WriteLine(NFack);
           // Console.WriteLine(NZnam);
          //  Console.WriteLine(znamenatel);

            int drob = NFack /(NZnam * znamenatel);
            Console.WriteLine(drob);
        }
    }
}
