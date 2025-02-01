using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.ZavrsniRad;

namespace Ucenje.KonzolnaAplikacijaZavrsniRad
{
    class ObradaSastavnice
    {
        public List<Sastavnice> Sastavnica { get; set; }
        public Izbornik Izbornik;

        public ObradaSastavnice()
        {
            Sastavnica = new List<Sastavnice>();
        }

        public ObradaSastavnice(Izbornik izbornik) : this()
        {
            this.Izbornik = izbornik;
        }


        public void PrikažiIzbornik()
        {
            Console.WriteLine("Izbornik za rad sa sastavnicama");
            Console.WriteLine("1. Prikaži sve sastavnice");
            Console.WriteLine("2. Unos novih sastavnica");
            Console.WriteLine("3. Promjena sastavnica");
            Console.WriteLine("4. Brisanje sastavnica");
            Console.WriteLine("5. Povratak u glavni izbornik");
            OdabirOpcijeIzbornika();
        }



        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziSastavnice();
                    PrikažiIzbornik();
                    break;
                case 2:
                    UnosNovihSastavnica();
                    PrikažiIzbornik();
                    break;
                case 3:
                    PromjeniPodatkeSastavnica();
                    PrikažiIzbornik();
                    break;
                case 4:
                    ObrisiSastavnice();
                    PrikažiIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    break;
            }
        }



        private void ObrisiSastavnice()
        {
            PrikaziSastavnice();
            if (Sastavnica.Count > 0)
            {
                var odabir = Pomocno.UcitajBroj("Odaberite redni broj sastavnice koju želite obrisati");
                if (odabir > 0 && odabir <= Sastavnica.Count)
                {
                    Sastavnica.RemoveAt(odabir - 1);
                }
            }
        }


        private void PromjeniPodatkeSastavnica()
        {
            PrikaziSastavnice();
            if (Sastavnica.Count == 0)
            {
                Console.WriteLine("Nema sastavnica za promjenu.");
                return;
            }

            int odabir;
            while (true) // Petlja za ponovni unos
            {
                odabir = Pomocno.UcitajBroj("Odaberite redni broj sastavnice koju želite promjeniti");
                if (odabir > 0 && odabir <= Sastavnica.Count)
                {
                    break; // Izlaz iz petlje ako je unos ispravan
                }
                Console.WriteLine("Neispravan unos. Molim pokušajte ponovno.");
            }

            var odabranaSastavnica = Sastavnica[odabir - 1];
            odabranaSastavnica.Naziv = Pomocno.UcitajString(
                "Unesite novi naziv sastavnice", odabranaSastavnica.Naziv);
            odabranaSastavnica.Opis = Pomocno.UcitajString("Unesite novi opis sastavnice", odabranaSastavnica.Opis);
            odabranaSastavnica.Cijena = Pomocno.UcitajDecimal("Unesite novu cijenu sastavnice", odabranaSastavnica.Cijena);
        }


        private void UnosNovihSastavnica()
        {
            Sastavnice s = new Sastavnice();
            s.Naziv = Pomocno.UcitajString("Unesite naziv sastavnice", 50, true);
            s.Opis = Pomocno.UcitajString("Unesite opis sastavnice", 50, true);
            s.Cijena = Pomocno.UcitajDecimal("Unesite cijenu sastavnice", 0, decimal.MaxValue);
            Sastavnica.Add(s);
        }


        private void PrikaziSastavnice()
        {
            Console.WriteLine("Popis sastavnica");
            for (int i = 0; i < Sastavnica.Count; i++)
            {
                Console.WriteLine("{0}. {1} - {2} - {3}", i + 1, Sastavnica[i].Naziv, Sastavnica[i].Opis, Sastavnica[i].Cijena);
            }
        }
    }
}