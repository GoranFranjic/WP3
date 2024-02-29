using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E14VjezbanjeRadaSObjektima
{
    internal class Program
    {

        private List<Osoba> Osobe;

        public bool PrikaziNaslov { get; private set; }

        /// <summary>
        /// Kreirati aplikaciju koja unosi, pregledava, mijenja i briše osobe
        /// </summary>
        public Program()
        {
            // konstruktor služi da bi konstruirao potrebne zavisnosti
            Osobe = new List<Osoba>();
            TestPodaci();
            PozdravnaPoruka();
            Izbornik();
        }

        private void TestPodaci()
        {
            Osobe.Add(new() { Ime = "Ana", Prezime = "Kat", Dob = 12 });
            Osobe.Add(new() { Ime = "Marko", Prezime = "Kekin", Dob = 14 });
        }

        private void Izbornik()
        {
            Console.WriteLine("1. Pregled osoba");
            Console.WriteLine("2. Unos nove osobe");
            Console.WriteLine("3. Promjena osobe");
            Console.WriteLine("4. Brisanje osobe");
            Console.WriteLine("5. Izlaz iz programa");
            OdaberiOpciju();
        }

        private void OdaberiOpciju()
        {
            switch (Pomocno.UcitajCijeliBroj("Odaberi opciju: "))
            {
                case 1:
                    PrikaziOsobe(true);
                    Izbornik();
                    break;
                case 2:
                    UnosNoveOsobe();
                    Izbornik();
                    break;
                    case 3:
                        PromjenaOsobe();
                    Izbornik(); break;
                    case 4:
                    BrisanjeOsobe();
                    Izbornik();
                    break;
                case 5:
                    Console.WriteLine("Program je završio, Doviđenja");
                    return;
                default:
                    Console.WriteLine("Nije dobra opcija");
                    Console.WriteLine("*****************");
                    break;
            }
            Izbornik();
        }

        private void BrisanjeOsobe()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("*** Brisanje osobe ***");
            Console.WriteLine("**********************");
            PrikaziOsobe();
            int izbor = Pomocno.UcitajCijeliBroj("Izaberi broj osobe", 1, Osobe.Count);
            Osobe.RemoveAt(izbor - 1);
        }

        private void PromjenaOsobe()
        {

            if(Osobe.Count == 0)
            {

                {
                    Console.WriteLine("Nema osobe za promjenu");
                    return;
                }

            }
            PrikaziOsobe();
            int izbor = Pomocno.UcitajCijeliBroj("Izaberi broj osobe (0 odustani)" , 0, Osobe.Count);
            if(izbor == 0)
            {

                return;

            }
            var o = Osobe[izbor - 1];
            o.Ime = Pomocno.UcitajString("Ucitaj ime");
            o.Prezime = Pomocno.UcitajString("Ucitaj Prezime");
            o.Dob = Pomocno.UcitajCijeliBroj("Ucitaj dob");
        }
        private void UnosNoveOsobe()
        {
            Osobe.Add(new()
            {
                Ime = Pomocno.UcitajString("Unesi ime osobe"),
                Prezime = Pomocno.UcitajString("Unesi prezime osobe"),
                Dob = Pomocno.UcitajCijeliBroj("Unesi dob osobe: ")
            });
        }

        private void PrikaziOsobe(bool PrikaziIzbornik=false)
        {

            if (PrikaziNaslov)
            {
                Console.WriteLine("*********************");
                Console.WriteLine("** Osobe u sustavu **");
                Console.WriteLine("*********************");
            }if(Osobe.Count == 0)
            {
                Console.WriteLine("Nema ni jedne osobe");

            }
            int i = 1;
            foreach (var o in Osobe)
            {
                Console.WriteLine(i++ + ". " + o);
            }
            Console.WriteLine("*****************************");
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("Osobe program V1");
            Console.WriteLine("****************");
        }
    }
}