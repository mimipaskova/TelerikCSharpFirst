using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextDate
{
    class NextDate
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            DateTime dateTime = new DateTime(year, month, day);
             Console.WriteLine( dateTime.AddDays(1).ToString("d.M.yyyy"));
         
        }
    }
}
