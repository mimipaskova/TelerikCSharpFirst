using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04N_VurhuK_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int chislitel=1;
            int znamenatel = 1;
            int K = int.Parse(Console.ReadLine());
            for (int i = 1; i < N; i++)
            {
                chislitel =chislitel*i ;
            }
            for (int i = 1; i < K; i++)
            {
                znamenatel = znamenatel * i;
            }
            Console.WriteLine(chislitel);
            Console.WriteLine(znamenatel);
            Console.WriteLine( chislitel / znamenatel);
        }
    }
}
