using System;
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
        public Izbornik Izbornik;

        public ObradaMaterijali()
        {
            Materijal = new List<Materijali>();
        }

        public ObradaMaterijali (Izbornik izbornik): this()
        {
            this.Izbornik = izbornik;
        }

        public void PrikažiIzbornik()
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


            private void ObrisiMaterijale()
        {
            PrikaziMaterijale();
            var m = Materijale[
                Pomocno.UcitajRasponBroja("Odaberi redni broj grupe za brisanje", 1, Materijali.Count) - 1
                ];
            if (Pomocno.UcitajBool("Sigurno obrisati " + m.Naziv + "? (DA/NE)", "da"))
            {
                Materijale.Remove(m);
            }
        }


        private void PromjeniPodatkeMaterijala()
        {
            PrikaziMaterijale();
            {
                var m = Materijali[
                    Pomocno.UcitajRasponBroja("Odaberi redni broj materijala za promjenu", 1, Materijali.Count) - 1
                    ];

                m.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru materijala", 1, int.MaxValue);
                m.Naziv = Pomocno.UcitajString("Unesi naziv materijala", 50, true);
                m.Vrste = Pomocno.UcitajString("Unesi vrstu materijala", 50, true);
            }

        }


        private void PrikaziMaterijale()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Materijali u aplikaciji");

            if (materijali == null || materijali.Count == 0)
            {
                Console.WriteLine("Nema dostupnih materijala.");
                Console.WriteLine("*****************************");
                return; // Izlazimo iz metode ako nema materijala
            }

            int rb = 0;
            foreach (var m in materijali)
            {
                Console.WriteLine(++rb + ". " + m.Naziv + " (" + m.Vrsta + ")");
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

            Materijal m = new Materijal();
            m.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru materijala", 1, int.MaxValue);
            m.Naziv = Pomocno.UcitajString("Unesi naziv materijala", 50, true);
            
            Materijali.Add(g);
        }
    }
}
    



    
      
    
