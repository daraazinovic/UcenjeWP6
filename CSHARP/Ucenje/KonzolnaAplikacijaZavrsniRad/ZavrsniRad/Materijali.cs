using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.ZavrsniRad
{
   public class Materijali: Entitet
    {
        public static int Count { get; internal set; }
        public string Naziv { get; set; } 
        public string Vrsta { get; set; } 
    }
}
