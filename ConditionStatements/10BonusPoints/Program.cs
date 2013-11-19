using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            int newPoints;

            if (points < 1 || points > 9)
            {
                Console.WriteLine("Points aren`t between 1 and 9");
            }
            else
            {
                if (points < 4)
                {
                    newPoints = points * 10;
                }
                else if (points > 3 && points < 7)
                {
                    newPoints = points * 100;
                }
                else
                {
                    newPoints = points * 1000;
                }
                Console.WriteLine(newPoints);
            }
        }
    }
}
