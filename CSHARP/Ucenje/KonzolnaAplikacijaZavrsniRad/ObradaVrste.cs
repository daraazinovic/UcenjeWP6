using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.ZavrsniRad;

namespace Ucenje.KonzolnaAplikacijaZavrsniRad
{
    class ObradaVrste
    {
        public List<Vrste> Vrsta { get; set; }
        public Izbornik Izbornik;

        public ObradaVrste()
        {
            Vrsta = new List<Vrste>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }

        private void UcitajTestnePodatke()
        {
            Vrsta.Add(new() { Sastav = "Drvo hrast" });
            Vrsta.Add(new() { Sastav = "Keramički prah" });
            Vrsta.Add(new() { Sastav = "Vosak" });
            Vrsta.Add(new() { Sastav = "Umjetno cvijeće" });
        }

        public ObradaVrste(Izbornik izbornik) : this()
        {
            this.Izbornik = izbornik;
        }


        public void PrikažiIzbornik()
        {
            Console.WriteLine("Izbornik za rad sa vrstama");
            Console.WriteLine("1. Prikaži sve vrste");
            Console.WriteLine("2. Unos novih vrsta");
            Console.WriteLine("3. Promjena vrsta");
            Console.WriteLine("4. Brisanje vrsta");
            Console.WriteLine("5. Povratak u glavni izbornik");
            OdabirOpcijeIzbornika();
        }



        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziVrste();
                    PrikažiIzbornik();
                    break;
                case 2:
                    UnosNovihVrsta();
                    PrikažiIzbornik();
                    break;
                case 3:
                    PromjeniPodatkeVrsta();
                    PrikažiIzbornik();
                    break;
                case 4:
                    ObrisiVrste();
                    PrikažiIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    break;
            }
        }



        private void ObrisiVrste()
        {
            PrikaziVrste();
            if (Vrsta.Count > 0)
            {
                var odabir = Pomocno.UcitajBroj("Odaberite redni broj vrste koju želite obrisati");
                if (odabir > 0 && odabir <= Vrsta.Count)
                {
                    Vrsta.RemoveAt(odabir - 1);
                }
            }
        }


        private void PromjeniPodatkeVrsta()
        {
            PrikaziVrste();
            if (Vrsta.Count == 0)
            {
                Console.WriteLine("Nema vrsta za promjenu.");
                return;
            }

            int odabir;
            while (true) // Petlja za ponovni unos
            {
                odabir = Pomocno.UcitajBroj("Odaberite redni broj vrsta koju želite promjeniti");
                if (odabir > 0 && odabir <= Vrsta.Count)
                {
                    break; // Izlaz iz petlje ako je unos ispravan
                }
                Console.WriteLine("Neispravan unos. Molim pokušajte ponovno.");
            }

            var odabranaVrsta = Vrsta[odabir - 1];
            odabranaVrsta.Sastav = Pomocno.UcitajString(
                "Unesite novi naziv vrste", odabranaVrsta.Sastav);
           
        }


        private void UnosNovihVrsta()
        {
            Vrste s = new Vrste();
            s.Sastav = Pomocno.UcitajString("Unesite sastav vrste", 50, true);
          
           
            Vrsta.Add(s);
        }


        private void PrikaziVrste()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Vrste u aplikaciji");
            int rb = 0;
            foreach (var s in Vrsta)
            {
                Console.WriteLine(++rb + ". " + s.Sastav); // prepisati metodu toString
            }
            Console.WriteLine("****************************");
        }
    }
}