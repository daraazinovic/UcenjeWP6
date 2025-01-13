using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt.edunova
{
    public class Grupa
    {
        public int Sifra { get; set; }
        public string Naziv { get; set; } = "";
        public int VelicinaGrupe { get; set; }
        public string? Predavac { get; set; }
        public Smjer Smjer { get; set; } = new Smjer();
        public Polaznik[]? Polaznici { get; set; }
    }
}
