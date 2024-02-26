using System;
using System.Linq;

namespace UcenjeCS
{
    internal class LjubavniKalkulator
    {
        public static void Izvedi()
        {
            string ime = "Marta";
            Dictionary<char, int> rezultati = BrojPonavljanjaSvihZnakova(ime);

            foreach (var kvp in rezultati)
            {
                Console.WriteLine($"Znak '{kvp.Key}' se pojavljuje {kvp.Value} puta u imenu {ime}.");
            }
        }

        static Dictionary<char, int> BrojPonavljanjaSvihZnakova(string tekst)
        {
            Dictionary<char, int> rezultati = new Dictionary<char, int>();

            foreach (char c in tekst)
            {
                if (rezultati.ContainsKey(c))
                {
                    rezultati[c]++;
                }
                else
                {
                    rezultati[c] = 1;
                }
            }

            // Provjera za ponovljena pojavljivanja
            foreach (var kvp in rezultati.ToArray())
            {
                if (kvp.Value > 1)
                {
                    int ponavljanja = 0;
                    foreach (char c in tekst)
                    {
                        if (c == kvp.Key)
                        {
                            ponavljanja++;
                        }
                    }
                    rezultati[kvp.Key] = ponavljanja;
                }
            }

            return rezultati;
        }
    }
}
