using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.E20KonzolnaAplikacija;
using Ucenje.ZavrsniRad;

namespace Ucenje.KonzolnaAplikacijaZavrsniRad
{
    internal class Izbornik
    {

        public ObradaMaterijali ObradaMaterijal { get; set; }
        public ObradaProizvod ObradaProizvod { get; set; }
        public ObradaVrste ObradaVrsta { get; set; }

        public Izbornik()
        {
            Pomocno.DEV = true;
            ObradaMaterijal = new ObradaMaterijali();
            ObradaProizvod = new ObradaProizvod();
            ObradaVrsta = new ObradaVrste(this);
            UcitajPodatke();
            PozdravnaPoruka();
            PrikaziIzbornik();
        }


        private void UcitajPodatke()
        {
            string docPath =
      Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (File.Exists(Path.Combine(docPath, "materijali.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(docPath, "materijali.json"));
                ObradaMaterijal.Materijali = JsonConvert.DeserializeObject<List<Materijal>>(file.ReadToEnd());
                file.Close();
            }

            if (File.Exists(Path.Combine(docPath, "proizvodi.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(docPath, "proizvodi.json"));
                ObradaProizvod.Proizvodi = JsonConvert.DeserializeObject<List<Proizvodi>>(file.ReadToEnd());
                file.Close();

            }

        }


      



        private void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad sa aplikacijom");
            Console.WriteLine("1. Rad sa materijalima");
            Console.WriteLine("2. Rad sa proizvodima");
            Console.WriteLine("3. Rad sa vrstama");
            Console.WriteLine("4. Izlaz iz aplikacije");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 4))
            {
                case 1:
                    ObradaMaterijal.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 2:
                    ObradaProizvod.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 3:
                    ObradaVrsta.PrikažiIzbornik();
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

      

    }

    
}
