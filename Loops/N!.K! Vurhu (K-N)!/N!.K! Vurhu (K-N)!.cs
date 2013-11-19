using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_.K__Vurhu__K_N__
{
    class Program
    {
        static void Main(string[] args)
        {
            //N!.K! Vurhu (K-N)!

            int N = int.Parse(Console.ReadLine());
            int NFack=1, KFack=1;
            int znamenatel = 1;
            int K = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                NFack = NFack * i;
            }
            for (int i = 1; i <= K; i++)
            {
                KFack = KFack * i;
            }
           
            for (int i = 1; i <= K-N; i++)
            {
                znamenatel = znamenatel * i;
            }
            Console.WriteLine(NFack);
            Console.WriteLine(KFack);
            Console.WriteLine(znamenatel);

            int drob = KFack * NFack/znamenatel;
            Console.WriteLine(drob);
        }
    }
}
