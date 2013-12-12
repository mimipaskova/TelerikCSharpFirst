using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Calc2
{
    class Program
    {

        static void Main()
        {
            string mainStr;
            int round = 0;
            int i = 0;
            int j = 0;
            int l;
            string c;
            int count = 0;
            int currentSol = 0;

            char[] symbols = new char[4] { '*', '/', '+', '-' };
            char[] mainstrList = new char[99];
            string[] numbers = new String[99];
            double[] solution = new Double[99];

            Console.Write("This is a simple calculator. Please enter an equation in the following format: A+B*C-D ");

            mainStr = Console.ReadLine();

            mainstrList = mainStr.ToCharArray();

            ArrayList numbers1 = new ArrayList(numbers);

            ArrayList mainStr1 = new ArrayList(mainstrList);
            ArrayList mainStr2 = new ArrayList(mainstrList);

            l = mainStr2.Count;

            foreach (char d in mainStr2)
            {
                count++;
                if (d == '*' || d == '/' || d == '+' || d == '-' || l == count) // || d != null || mainStr2.Count == count
                {
                    if (l != count)
                    {
                        numbers1[j + 1] = Convert.ToString(mainStr1[i]);
                        mainStr1.RemoveAt(i);
                        i--;
                    }
                    do
                    {
                        numbers1[j] = Convert.ToString(mainStr1[i]) + numbers1[j];
                        mainStr1.RemoveAt(i);
                        i--;
                    } while (i >= 0);
                    j = j + 2;
                }
                i++;
            }

            ArrayList numbers2 = new ArrayList(numbers1);
            i = 0;

            foreach (char s in symbols)
            {
                do
                {
                    c = Convert.ToString(numbers1[i]);
                    if ((c == "*" && round == 0) | (c == "/" && round == 1) | (c == "+" && round == 2) | (c == "-" && round == 3))
                    {
                        if (c == "*")
                        {
                            solution[currentSol] = Convert.ToDouble(numbers1[i - 1]) * Convert.ToDouble(numbers1[i + 1]);
                            numbers1.RemoveAt(i - 1);
                            numbers1.RemoveAt(i - 1);
                            numbers1[i - 1] = solution[currentSol];
                            i--;
                        }

                        if (c == "/")
                        {
                            solution[currentSol] = Convert.ToDouble(numbers1[i - 1]) / Convert.ToDouble(numbers1[i + 1]);
                            numbers1.RemoveAt(i - 1);
                            numbers1.RemoveAt(i - 1);
                            numbers1[i - 1] = solution[currentSol];
                            i--;
                        }
                        if (c == "+")
                        {
                            solution[currentSol] = Convert.ToDouble(numbers1[i - 1]) + Convert.ToDouble(numbers1[i + 1]);
                            numbers1.RemoveAt(i - 1);
                            numbers1.RemoveAt(i - 1);
                            numbers1[i - 1] = solution[currentSol];
                            i--;
                        }
                        if (c == "-")
                        {
                            solution[currentSol] = Convert.ToDouble(numbers1[i - 1]) - Convert.ToDouble(numbers1[i + 1]);
                            Console.WriteLine(solution[currentSol]);
                            numbers1.RemoveAt(i - 1);
                            numbers1.RemoveAt(i - 1);
                            numbers1[i - 1] = solution[currentSol];
                            i--;
                        }
                    }
                    i++;
                    l = numbers1.Count;
                } while (l > i);
                round++;
                i = 0;
            }
            Console.WriteLine("= " + solution[0]);
            Console.ReadLine();
        }
    }
}