namespace UcenjeCS
{
    internal class E05Nizovi
    {

        public static void Izvedi()
        {
            int[] Temperature = new int[12];
            Temperature[0] = 1; //[0] ovo je indeks niza
            Temperature[Temperature.Length - 1] = 2; //zadnje mjesto

            Console.WriteLine(Temperature);
            Console.WriteLine(string.Join(",", Temperature));

            string[] gradovi = new string[3];
            gradovi[0] = "Osijek";
            gradovi[1] = "Donji";
            gradovi[2] = "Zagreb";

            Console.WriteLine(string.Join("", gradovi));

            //skraćeni način definiranja niza

            int[] brojevi = { 2, 3, 4, 5, 6, 5, 6, 7, 3 };

            //ispišite broj 7

            Console.WriteLine(brojevi[4]);

            //prvi element niza

            Console.WriteLine(brojevi[0]);

            //Console.WriteLine(brojevi.[brojevi.Length - 1]);

            //dvodimenzionalni niz - matrica (tablica)

            int[,] tablica =
            {
                {1,2,3},
                {4,5,6},
                {7,8,9},



            };

            Console.WriteLine(tablica[1, 2]);


            int[] niz = { 1, 2, 3, 4, 5 };


            Console.WriteLine(niz[0]);
            Console.WriteLine(niz[1]);
            Console.WriteLine(niz[2]);
            Console.WriteLine(niz[3]);
            Console.WriteLine(niz[4]);

            int i= 0;

            i++;

            Console.WriteLine(i);



        }
    }
}