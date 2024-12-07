using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04Z3
    {
        public static void Izvedi()
        {
            Console.Write("Unesi prvi cijeli broj: ");
            int broj1 = int.Parse(Console.ReadLine());

                Console.Write("Unesi drugi cijeli broj");
            int broj2 = int.Parse(Console.ReadLine());

                bool uvjet = broj1 < broj2;
            Console.WriteLine(uvjet);

            if (uvjet)
            {
                Console.WriteLine("Manji broj je: ");
            }


        }

        



    }
}
