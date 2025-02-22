﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.ZavrsniRad;

namespace Ucenje.KonzolnaAplikacijaZavrsniRad
{
    internal class ObradaMaterijali
    {

        public List<Materijali> Materijal { get; set; }
        public object Materijale { get; private set; }
        public List<Materijal>? Materijali { get; internal set; }

        public Izbornik Izbornik;

        public ObradaMaterijali()
        {
            Materijal = new List<Materijali>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }

        private void UcitajTestnePodatke()
        {
            Materijal.Add(new() { Naziv = "Keramički prah", Vrsta = "Građevinski" });
            Materijal.Add(new() { Naziv = "Vosak", Vrsta = "Prirodni" });
            Materijal.Add(new() { Naziv = "Drvo", Vrsta = "Prirodni" });
        }

        public ObradaMaterijali (Izbornik izbornik): this()
        {
            this.Izbornik = izbornik;
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad sa materijalima");
            Console.WriteLine("1. Prikaži sve materijale");
            Console.WriteLine("2. Unos novih materijala");
            Console.WriteLine("3. Promjena materijala");
            Console.WriteLine("4. Brisanje materijala");
            Console.WriteLine("5. Povratak u glavni izbornik");
            OdabirOpcijeIzbornika();
        }


        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziMaterijale();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNovihMaterijala();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromjeniPodatkeMaterijala();
                    PrikaziIzbornik();
                    break;
                case 4:
                    ObrisiMaterijale();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    break;
            }
        }

            private void ObrisiMaterijale()
        {
            PrikaziMaterijale();
            if (Materijal.Count > 0)
            {
                var odabir = Pomocno.UcitajBroj("Odaberite redni broj Materijala koju želite obrisati");
                if (odabir > 0 && odabir <= Materijal.Count)
                {
                    Materijal.RemoveAt(odabir - 1);
                }
            }
        }


        private void PromjeniPodatkeMaterijala()
        {
            PrikaziMaterijale();
            if (Materijal.Count == 0)
            {
                Pomocno.PrikaziPoruku("Nema materijala za promjenu.");
                return; // Prekidamo funkciju ako nema materijala
            }
            {
                var m = Materijal[
                    Pomocno.UcitajRasponBroja("Odaberi redni broj materijala za promjenu", 1, int.MaxValue)-1
                    ];

                m.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru materijala", 1, int.MaxValue);
                m.Naziv = Pomocno.UcitajString("Unesi naziv materijala", 50, true);
                m.Vrsta = Pomocno.UcitajString("Unesi vrstu materijala", 50, true);
            }

        }


        private void PrikaziMaterijale()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Materijali u aplikaciji");
            int rb = 0;
            foreach (var m in Materijal)
            {
                Console.WriteLine(++rb + ". " + m.Naziv);
            }
            Console.WriteLine("****************************");
        }
      



        public static void Main(string[] args)
        {
            // Primjer korištenja:
            List<Materijali> materijali = new List<Materijali>()
        {
            new Materijali { Naziv = "Keramički prah", Vrsta = "Građevinski" },
            new Materijali { Naziv = "Vosak", Vrsta = "Prirodni" },
            new Materijali { Naziv = "Drvo", Vrsta = "Prirodni" },
            new Materijali {Naziv = "Umjetno cvijeće i ostali umjetan materijal", Vrsta = "Plastični"},
            new Materijali {Naziv = "Lakovi i boje", Vrsta= "Bojila"}
        };
            Console.WriteLine("********************************");
        } 



        private void UnosNovihMaterijala()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Unesite tražene podatke o materijalima");

            Materijali m = new Materijali();
            m.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru materijala", 1, int.MaxValue);
            m.Naziv = Pomocno.UcitajString("Unesi naziv materijala", 50, true);

            Materijal.Add(m);
        }
    }
}
    



    
      
    
