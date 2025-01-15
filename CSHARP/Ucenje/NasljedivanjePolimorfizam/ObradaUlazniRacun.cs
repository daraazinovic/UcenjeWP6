using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.NasljedivanjePolimorfizam
{
    public class ObradaUlazniRacun : Obrada
    {
        public override void Procesuiraj()
        {
            Console.WriteLine("Obrađujem ulazni račun");
            Console.WriteLine("Plati ga");
        }
    }
}
