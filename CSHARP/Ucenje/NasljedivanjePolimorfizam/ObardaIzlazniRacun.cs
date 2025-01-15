using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.NasljedivanjePolimorfizam
{
    public class ObradaIzlazniRacun : Obrada
    {
        public override void Procesuiraj()
        {
            Console.WriteLine("Obrađujem izlazni raćun");
            Console.WriteLine("Pošalji ga");
        }

    }
}
