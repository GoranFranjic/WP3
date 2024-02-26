using System;
using System.Collections.Generic;

namespace UcenjeCS
{
    public static class LoveCalculator
    {
        public static void Izvedi()
        {
            Console.WriteLine("Enter the first name:");
            string firstName = Console.ReadLine().ToLower();
            Console.WriteLine("Enter the second name:");
            string secondName = Console.ReadLine().ToLower();

            Dictionary<char, int> letterCounts = CountLetters(firstName + secondName);

            Console.WriteLine("Letter Counts for Both Names Combined:");
            foreach (var entry in letterCounts)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }

        static Dictionary<char, int> CountLetters(string s)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (Char.IsLetter(c))
                {
                    if (counts.ContainsKey(c))
                    {
                        counts[c]++;
                    }
                    else
                    {
                        counts[c] = 1;
                    }
                }
            }

            return counts;
        }
    }
}
