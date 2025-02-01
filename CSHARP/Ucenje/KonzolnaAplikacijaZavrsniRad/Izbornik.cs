using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.ZavrsniRad;

namespace Ucenje.KonzolnaAplikacijaZavrsniRad
{
    internal class Izbornik
    {

        public ObradaMaterijali ObradaMaterijali { get; set; }
        public ObradaProizvod ObradaProizvod { get; set; }
        public ObradaSastavnice ObradaSastavnice { get; set; }

        public Izbornik()
        {
            Pomocno.DEV = true;
            ObradaMaterijali = new ObradaMaterijali();
            ObradaProizvod = new ObradaProizvod();
            ObradaSastavnice = new ObradaSastavnice(this);
            UcitajPodatke();
            PozdravnaPoruka();
            PrikaziIzbornik();
        }

        private void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad sa aplikacijom");
            Console.WriteLine("1. Rad sa materijalima");
            Console.WriteLine("2. Rad sa proizvodima");
            Console.WriteLine("3. Rad sa sastavnicama");
            Console.WriteLine("4. Izlaz iz aplikacije");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 4))
            {
                case 1:
                    ObradaMaterijali.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 2:
                    ObradaProizvod.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 3:
                    ObradaSastavnice.PrikažiIzbornik();
                    PrikaziIzbornik();
                    break;
                case 4:
                    Console.WriteLine("Izlaz iz aplikacije");
                    break;
            }
        }

        private void PozdravnaPoruka()
        {

            Console.WriteLine("*********************************");
            Console.WriteLine("*** Trgovina rukotvorina Console APP ***");
            Console.WriteLine("*********************************");

        }

        private void UcitajPodatke()
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(docPath, "materijali.json");

            if (File.Exists(filePath))
            {
                try
                {
                    using (StreamReader file = new StreamReader(filePath)) // using blok
                    using (JsonTextReader reader = new JsonTextReader(file)) // streaming obrada
                    {
                        ObradaMaterijali.Materijal = JsonConvert.DeserializeObject<List<Materijali>>(file.ReadToEnd());
                    }

                    if (ObradaMaterijali.Materijal == null)
                    {
                        // Datoteka je možda prazna ili sadrži nevažeći JSON. Postavite na praznu listu.
                        ObradaMaterijali.Materijal = new List<Materijali>();
                        Console.WriteLine("Upozorenje: Datoteka je prazna ili sadrži nevažeći JSON. Učitana je prazna lista.");
                    }
                }
                catch (Exception ex) // Hvatanje iznimki
                {
                    Console.WriteLine($"Greška pri učitavanju podataka: {ex.Message}");
                    // Ovdje možete dodati dodatnu logiku za rukovanje greškom, npr. ponovni pokušaj, postavljanje na default vrijednosti itd.
                    ObradaMaterijali.Materijal = new List<Materijali>(); // Postavljanje na praznu listu u slučaju greške
                }
            }
            else
            {
                Console.WriteLine("Datoteka materijali.json ne postoji.");
                ObradaMaterijali.Materijal = new List<Materijali>(); // Inicijalizacija na praznu listu ako datoteka ne postoji.
            }

        } 

    }

    
}
