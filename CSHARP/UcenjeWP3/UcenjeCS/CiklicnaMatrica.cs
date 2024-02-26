using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace UcenjeCS
{
    internal class CiklicnaMatrica
    {
        public static void Izvedi()
        {
            bool dev = false;

            Console.Write("Broj redova: ");
            int redova = int.Parse(Console.ReadLine());

            Console.Write("Broj stupaca: ");
            int stupci = int.Parse(Console.ReadLine());

           // int redova = dev ? 5 : int.Parse(Console.ReadLine());
           // int stupci = dev ? 5 : int.Parse(Console.ReadLine());

            int[,] matrica = new int[redova, stupci];

            int brojac = 1;
            int maxBroj = redova * stupci;

            int gornjaGranicaRedova = redova - 1;
            int gornjaGranicaStupaca = stupci - 1;
            int donjaGranicaRedova = 0;
            int donjaGranicaStupaca = 0;

            while (brojac <= maxBroj)
            {
                for (int i = gornjaGranicaStupaca; i >= donjaGranicaStupaca; i--)
                {
                    matrica[gornjaGranicaRedova, i] = brojac++;
                }

                if (brojac > maxBroj) { break; }

                gornjaGranicaRedova--;

                for (int i = gornjaGranicaRedova; i >= donjaGranicaRedova; i--)
                {
                    matrica[i, donjaGranicaStupaca] = brojac++;
                }

                if (brojac > maxBroj) { break; }

                donjaGranicaStupaca++;

                for (int i = donjaGranicaStupaca; i <= gornjaGranicaStupaca; i++)
                {
                    matrica[donjaGranicaRedova, i] = brojac++;
                }

                if (brojac > maxBroj) { break; }

                donjaGranicaRedova++;

                for (int i = donjaGranicaRedova; i <= gornjaGranicaRedova; i++)
                {
                    matrica[i, gornjaGranicaStupaca] = brojac++;
                }
                gornjaGranicaStupaca--;
            }

            for (int i = 0; i < redova; i++)
            {
                for (int j = 0; j < stupci; j++)
                {
                    Console.Write(matrica[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}