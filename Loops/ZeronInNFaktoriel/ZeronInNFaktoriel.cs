using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeronInNFaktoriel
{
    class ZeronInNFaktoriel
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            long factoriel = 1;
            long ostatuc = 0;
            int br = 0;
            for (int i = 1; i < n; i++)
            {
                factoriel *= i;
            }
          //  Console.WriteLine(factoriel);
            while (ostatuc == 0)
            {
                ostatuc = factoriel % 10;
                factoriel = factoriel / 10;
                br++;
            }
            Console.WriteLine(br);

        }
    }
}
