using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.Pozitivan
{
    internal class PozitivanNegativanbroj
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesi cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());
            bool uvjet = broj == 0;

            if (broj == 0) 
            {
                Console.WriteLine("Broj je 0");
            }

            if (broj < 0)
            {
                Console.WriteLine("Broj je negativan");
            }

            if (broj > 0)
            {
                Console.WriteLine("Broj je pozitivan");
            }
        }
    }
}
