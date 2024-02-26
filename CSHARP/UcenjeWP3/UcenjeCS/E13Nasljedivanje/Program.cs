
﻿using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13Nasljedivanje
{
    internal class Program
    {

        // 5. vrsta metode: Konstruktor

        public Program()
        {
            Console.WriteLine("Nalazim se u konstruktoru Programa u namespace E13..");

            // u konstrukturu se pripreme potrebne zavisnosti - konstruiraju se
            Primjer1();

            Primjer2();

            Primjer3();

            Primjer4();
        }

        private void Primjer4()
        {
            Polaznik p1 = new() { Ime = "Iva" };
            Polaznik p2 = new() { Ime = "Iva" };

            Console.WriteLine(p1==p2);

            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
        }

        private void Primjer3()
        {
            var p = new Predavac()

            {

                Ime="Karlo",
                Prezime="Sat",
                Iban = "HR22"


            };
            Console.WriteLine(p);

            
        }

        private void Primjer2()
        {
            // Ne mogu instancirati apstraktnu klasu
            // Osoba osoba = new Osoba();

            OsobaImpl osoba = new OsobaImpl();
            osoba.Ime = "Luka";


            osoba.GetType();


        }

        private void Primjer1()
        {
            Predavac p = new Predavac();
            p.Ime = "Pero";
            p.Iban = "HR455";

            Polaznik polaznik = new Polaznik();
            polaznik.Ime = "Kata";
            polaznik.BrojUgovora = "12/2024";


            // Ispišite u konzolu s objekta p HR455
            Console.WriteLine(p.Iban);


        }
    }
}