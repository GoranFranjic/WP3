namespace UcenjeCS
{
    internal class E06ForPetlja
    {

        public static void Izvedi()
        {

            for (int i = 0; i < 10; i = i + 1)

            {

                Console.WriteLine("Edunova " + i);

            }

            int[] niz = { 1, 2, 3, 44, 5, 6, 7, 8, 9 };

            for (int i = 0; i < niz.Length; i++)
            {


                Console.WriteLine(niz[i]);
            }

            // ispisati sve parne od 3 do 43

            for (int i = 3; i <= 43; i++)

            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }
            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {

                suma += 1;

            }

            Console.WriteLine(suma);

            for (int i = 78; i >= 4; i--)
            {
                Console.WriteLine(i);

            }

            for (int i = 1; i <= 100; i += 7)
            {

                Console.WriteLine(i);

            }

            for (int j = 1; j <= 10; j++)
            {

                Console.WriteLine(j);

            }





            for (int i = 0; i < 10; i++)

            {

                if (i == 3)
                {
                    break;
                }
                Console.WriteLine(i);

            }

            for (int i = 0; i < 10; i++)
            {
                goto labela;
            }

        labela:
            Console.WriteLine("nastavljam nakon vanjske petlje");


            for(; ; )
            {
                Console.WriteLine(new Random().NextInt64(1,100));
                break;
            }





             

        }
    }
}
