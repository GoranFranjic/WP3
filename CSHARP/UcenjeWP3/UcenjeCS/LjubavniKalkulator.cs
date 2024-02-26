using System;
using System.Linq;
using System.Text;

namespace UcenjeCS
{
    internal class LjubavniKalkulator
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesite prvo ime: ");
            string ime1 = Console.ReadLine().ToLower();

            Console.WriteLine("Unesite drugo ime: ");
            string ime2 = Console.ReadLine().ToLower();

            string combinedNames = ime1 + ime2;

            StringBuilder result = new StringBuilder();
            CalculateLoveScore(combinedNames, 0, new int[combinedNames.Length], result);

            Console.WriteLine("Rezultat: " + result.ToString());
        }

        private static void CalculateLoveScore(string s, int index, int[] counts, StringBuilder result)
        {
            if (index >= s.Length)
            {
                // Build the result string
                for (int i = 0; i < counts.Length / 2; i++)
                {
                    result.Append(counts[i] + counts[counts.Length - 1 - i]);
                }

                if (s.Length % 2 != 0)
                {
                    result.Append(counts[s.Length / 2]);
                }

                return;
            }

            char currentChar = s[index];
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == currentChar)
                {
                    count++;
                }
            }

            counts[index] = count;
            CalculateLoveScore(s, index + 1, counts, result);
        }
    }
}