using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E12KlasaObjekt
{
    internal class Program
    {

        public static void Izvedi()
        {
            Osoba osoba = new Osoba();

            osoba.Ime = Pomocno.UcitajString("Unesi ime osobe");
            osoba.Prezime = "Parić";

            Console.WriteLine(osoba.ImePrezime());

            
        }

    }
}
