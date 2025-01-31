using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.ZavrsniRad
{
    public class Sastavnice : Entitet
    {
        public List<Proizvodi> Proizvodi { get; set; } 
        public List<Materijali> Materijali { get; set; }
        public string Naziv { get; internal set; }
        public string Opis { get; internal set; }
        public decimal Cijena { get; internal set; }
    }
}
