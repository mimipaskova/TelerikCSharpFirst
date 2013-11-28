using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Spiral
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] spiral = new int[n,n];

            for (int i = 0; i < n*n; i++)
			{
			 
                for (int j = 0; j < n; j++)
			{
                    if(!(j==spiral.Length))
                    {
                    spiral[i,j]=j+1;
                    }
                    else
                    {
                        break;
                    }			 
			}
                for (int p = 0; p < n; p++)
			{
                    			 
			}

			}          
           


            }
        }
    }
}
