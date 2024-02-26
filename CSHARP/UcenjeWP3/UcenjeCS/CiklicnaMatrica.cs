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
            Console.Write("Broj redaka: ");
            int redak = int.Parse(Console.ReadLine());

            Console.Write("Broj stupaca: ");
            int stupac = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c = 2, d = 3, x = 1, i = 0;

            int[,] Matrix = new int[redak, stupac];

            for (i = 1; i <= stupac; i++)
            {
                Matrix[redak - 1, stupac - i] = x++;
            }
            for (i = 2; i <= redak; i++)
            {
                Matrix[redak - i, 0] = x++;
            }
            for (i = 1; i < stupac; i++)
            {
                if (redak <= 1)
                {
                    break;
                }
                Matrix[0, i] = x++;
            }
            for (i = 1; i < redak - 1; i++)
            {
                Matrix[i, stupac - 1] = x++;
            }

            int y = 1;
            for (y = 1; y < redak && y < stupac; y++)
            {
                if (redak * stupac == x + 1)
                {
                    break;
                }
                y++;

                for (i = c; i < stupac - a; i++)
                {
                    if (redak == 2 || stupac == 2 || redak * stupac == x - 1)
                    {
                        break;
                    }
                    Matrix[redak - c, stupac - i] = x++;
                }

                for (i = d; i < redak - a; i++)
                {
                    if (redak == 2 || stupac == 2 || redak * stupac == x - 1)
                    {
                        break;
                    }
                    Matrix[redak - i, b] = x++;
                }

                for (i = c; i < stupac - b; i++)
                {
                    if (redak == 2 || stupac == 2 || redak * stupac == x - 1)
                    {
                        break;
                    }
                    Matrix[b, i] = x++;
                }

                for (i = c; i < redak - c; i++)
                {
                    if (redak == 2 || stupac == 2 || redak * stupac == x - 1)
                    {
                        break;
                    }
                    Matrix[i, stupac - c] = x++;
                }
                a++;
                b++;
                c++;
                d++;
            }

            Console.WriteLine();
            for (i = 0; i < redak; i++)
            {
                for (int j = 0; j < stupac; j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
