using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.ZavrsniRad;

namespace Ucenje.KonzolnaAplikacijaZavrsniRad
{
    internal class ObradaProizvod : Entitet
    {
        public List<Proizvodi> Proizvodi { get; set; }

        public ObradaProizvod()
        {
            Proizvodi = new List<Proizvodi>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }

        }

        private void UcitajTestnePodatke()
        {
            Proizvodi.Add(new() { Naziv = "'Zahvalnice za svatove" });
            Proizvodi.Add(new() { Naziv = "Kućica sa crkvom" });
            Proizvodi.Add(new() { Naziv = "Kapela sa mirisnom svijećom" });
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za izbor proizvoda");
            Console.WriteLine("1. Pregled svih proizvoda");
            Console.WriteLine("2.Pregled detalja pojedinog proizvoda");
            Console.WriteLine("3. Unos novog proizvoda");
            Console.WriteLine("4. Promjena podataka postojećeg proizvoda");
            Console.WriteLine("5. Brisanje proizvoda");
            Console.WriteLine("6. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziProizvode();
                    PrikaziIzbornik();
                    break;
                case 2:
                    PregledDetaljaPojedinogProizvoda();
                    PrikaziIzbornik();
                    break;
                case 3:
                    UnosNovogProizvoda();
                    PrikaziIzbornik();
                    break;
                case 4:
                    PromjeniPodatkeProizvoda();
                    PrikaziIzbornik();
                    break;
                case 5:
                    ObrisiProizvod();
                    PrikaziIzbornik();
                    break;
                case 6:
                    Console.Clear();
                    break;
            }
        }

        private void PregledDetaljaPojedinogProizvoda()
        {
            PrikaziProizvode();
            var p = Proizvodi[
                Pomocno.UcitajRasponBroja("Odaberi redni broj smjera za detalje", 1, Proizvodi.Count) - 1
                ];
            Console.WriteLine("--------------------");
            Console.WriteLine("Detalji proizvoda:");
            Console.WriteLine("Šifra: " + p.Sifra);
            Console.WriteLine("Naziv: " + p.Naziv);
            Console.WriteLine("Cijena: " + p.Cijena);
            Console.WriteLine("Izrađuje se od: " + p.IzradujeSeOd);
            Console.WriteLine("Namjena: " + p.Namjena);
          
            Console.WriteLine("--------------------");
        }

        private void ObrisiProizvod()
        {
            PrikaziProizvode();
            var odabrani = Proizvodi[
                Pomocno.UcitajRasponBroja("Odaberi redni broj proizvoda za brisanje",
                1, Proizvodi.Count) - 1
                ];
            if (Pomocno.UcitajBool("Sigurno obrisati " + odabrani.Naziv + " " + "? (DA/NE)", "da"))
            {
                Proizvodi.Remove(odabrani);
            }
        }


        private void PromjeniPodatkeProizvoda()
        {
            PrikaziProizvode();
            var p = Proizvodi[
                Pomocno.UcitajRasponBroja("Odaberi redni broj smjera za detalje", 1, Proizvodi.Count) - 1
                ];
            Console.WriteLine("--------------------");
            Console.WriteLine("Detalji proizvoda:");
            Console.WriteLine("Šifra: " + p.Sifra);
            Console.WriteLine("Naziv: " + p.Naziv);
            Console.WriteLine("Cijena: " + p.Cijena);
            Console.WriteLine("Izrađuje se od: " + p.IzradujeSeOd);
            Console.WriteLine("Namjena: " + p.Namjena);
            Console.WriteLine("--------------------");
        }

        public void PrikaziProizvode()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Proizvodi u aplikaciji");
            int rb = 0;
            foreach (var p in Proizvodi)
            {
                Console.WriteLine(++rb + ". " + p.Naziv); // prepisati metodu toString
            }
            Console.WriteLine("****************************");

        }


        public void UnosNovogProizvoda()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Unesite tražene podatke o proizvodu");
            Proizvodi.Add(new()
            {
                Sifra = Pomocno.UcitajRasponBroja("Unesi šifru proizvoda", 1, int.MaxValue),
                Naziv = Pomocno.UcitajString("Unesi naziv proizvoda", 50, true),
                IzradujeSeOd = Pomocno.UcitajString("Unesi od čega se proizvod izrađuje", 70, true),
                Cijena = Pomocno.UcitajBroj("Unesi cijenu proizvoda"),
                Namjena = Pomocno.UcitajString("Unesi namjenu proizvoda", 50, true)
            });
        }

       


    }
}
