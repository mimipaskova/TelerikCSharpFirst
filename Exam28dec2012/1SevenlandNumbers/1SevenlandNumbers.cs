using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1SevenlandNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            int prom=0;
            int edin=0;
            int stot=0;

            if (K == 666)
            {
                Console.WriteLine(1000);
            }

            else if(K%10!=6)
            {
                Console.WriteLine(K+1);
            }
            else
            {
                prom=K/10;
                if(prom%10!=6)
                {
                    edin=K%10;
                    edin=0;
                    prom=prom+1;
                    Console.WriteLine(prom+""+edin);
                }
                else
                {
                    stot=K/100;
                    if(stot%10!=6)
                    {
                        edin=K%10;
                        edin=0;
                        prom=(K%100)/10;
                        prom = 0;
                        stot=stot+1;
                        Console.WriteLine(stot+""+prom +""+edin);
                    }
                }
            }

        }
    }
}
