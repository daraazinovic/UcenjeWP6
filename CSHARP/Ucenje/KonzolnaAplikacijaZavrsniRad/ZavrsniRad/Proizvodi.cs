using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.ZavrsniRad
{
    public class Proizvodi: Entitet, IComparable<Proizvodi>
    {
        public Proizvodi()
        {
            Cijena = 0;
        }
    


        public string Naziv { get; set; } 
        public string IzradujeSeOd { get; set; } 
        public float Cijena { get; set; }
        public string Namjena { get; set; }


        public int CompareTo(Proizvodi other)
        {
            return Cijena.CompareTo(other.Cijena);
        }

    }
}
