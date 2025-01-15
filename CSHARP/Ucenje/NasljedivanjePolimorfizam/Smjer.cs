using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18NasljedivanjePolimorfizam
{
    public class Smjer:Entitet
    {
        public string Naziv { get; set; } = "";

        public override string ToString()
        {
            return Naziv;
        }


        public override bool Equals(object? obj)
        {
            return ((Smjer)obj).Naziv.Equals(Naziv);
        }
    }


}
