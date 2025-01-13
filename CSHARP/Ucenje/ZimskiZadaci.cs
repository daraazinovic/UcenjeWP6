using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class ZimskiZadaci
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesite duljinu pravokutnika:");
            double duljina = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Unesite širinu pravokutnika:");
            double sirina = Convert.ToDouble(Console.ReadLine());

            double povrsina = duljina * sirina;
            Console.WriteLine("Površina pravokutnika je: " + povrsina);







        }



    }
}
