namespace UcenjeCS
{
    internal class Z05
    {
        //unosi cijeli broj
        //ispisuje zbroj svih brojeva od 1 do unesenog broja
        //primjer za 100 će ispisati 5050
        public static void Izvedi()
        {
            int broj = 100;

            for (int i = 1; i <= 100; i++)

            {
                broj += i;
            }

            Console.WriteLine(broj);

            // Program unosi cijele brojeve sve dok se ne unese -1
            // Program ispisuje najmanji uneseni broj


            //int i; najveci = int.MaxValue;

            for (; ; )
            {
                Console.WriteLine("Unesi broj: ");
                int b = int.Parse(Console.ReadLine());
                bool prim = true;
                for (int i = 2; i < broj; i++)
                {

                    if (b % i == 0)

                    {

                        prim = false;

                    }

                }
                Console.WriteLine(b + "" + (prim ? "je" : "nije") + "prim broj");

            }





        }

    }
}
