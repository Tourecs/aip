using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace aip
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();
            string k = "";
            Regex regex = new Regex(@"a.b");
            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                k += match.Value[1];
            }

            char mostfreqchar = FindMostFrequentChar(k);
            Console.WriteLine($"Самый часто повторяющийся символ: {mostfreqchar}");
        }

        static char FindMostFrequentChar(string String)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in String)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            char mostfreqchar = String[0];
            int maxCount = 0;

            foreach (var kvp in charCount)
            {
                if (kvp.Value > maxCount)
                {
                    maxCount = kvp.Value;
                    mostfreqchar = kvp.Key;
                }
            }
            return mostfreqchar;
        }
    }
}
