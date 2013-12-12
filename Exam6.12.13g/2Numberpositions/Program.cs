using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Numberpositions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string numbers = Console.ReadLine();
            //int myNumbers = 0;
            //myNumbers = Convert.ToInt32(numbers);
            string[] a = new string[100];
            a = numbers.Select(c => c.ToString()).ToArray();
            Int64 sum = 0;
            Int64 br = 0;
           // Console.WriteLine(myNumbers);

            numbers = numbers.Trim(new Char[] { '-' });

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == '-')
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        string[] newString = new string[100];
                        newString[j] = a[j + 1];
                    }

                    if (Char.Parse( a[i])>='0' && Char.Parse(a[i])<='9' && i % 2 != 0)
                    {
                        br = br + 1;
                        sum += Int64.Parse(a[i]);
                    }
                }

                else if (i % 2 != 0)
                {
                    br = br + 1;
                    sum +=Int64.Parse( a[i]);
                }
               
            }
            Console.WriteLine(br + " " + sum);           
        }
    }
}
