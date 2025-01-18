using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.ZavrsniRad;
namespace Ucenje.ZavrsniRad
{
    public abstract class Entitet : Object
    {
        public int Sifra { get; set; }

        public override string ToString()
        {
            return Sifra.ToString();
        }
    }
}
