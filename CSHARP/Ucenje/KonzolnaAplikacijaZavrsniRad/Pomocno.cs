using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.KonzolnaAplikacijaZavrsniRad
{
    internal class Pomocno
    {

        public static bool DEV = false;


        internal static bool UcitajBool(string poruka, string trueValue)
        {
            Console.Write(poruka + ": ");
            return Console.ReadLine().Trim().ToLower() == trueValue;
        }

        internal static int UcitajRasponBroja(string poruka, int min, int max)
        {
            int b;
            while (true)
            {
                try
                {
                    Console.Write(poruka + ": ");
                    b = int.Parse(Console.ReadLine());
                    if (b < min || b > max)
                    {
                        throw new Exception();
                    }
                    return b;
                }
                catch
                {
                    Console.WriteLine("Unos nije dobar, unos mora biti u rasponu {0} do {1}", min, max);
                }
            }
        }


        internal static string UcitajString(string poruka, int max, bool obavezno)
        {
            string s;
            while (true)
            {
                Console.Write(poruka + ": ");
                s = Console.ReadLine().Trim().ToLower();
                if ((obavezno && s.Length == 0) || s.Length > max)
                {
                    Console.WriteLine("Unos obavezan, maksimalno dozvoljeno {0} znakova", max);
                    continue;
                }
                return s;
            }
        }


        internal static decimal UcitajDecimal(string poruka, decimal min, decimal max)
        {
            decimal d;
            while (true)
            {
                try
                {
                    Console.Write(poruka + ": ");
                    d = decimal.Parse(Console.ReadLine());
                    if (d < min || d > max)
                    {
                        throw new Exception();
                    }
                    return d;
                }
                catch
                {
                    Console.WriteLine("Unos nije dobar, unos mora biti u rasponu {0} do {1}", min, max);
                }
            }
        }


        internal static int UcitajBroj(string poruka)
        {
            int b;
            while (true)
            {
                try
                {
                    Console.Write(poruka + ": ");
                    b = int.Parse(Console.ReadLine());
                    return b;
                }
                catch
                {
                    Console.WriteLine("Unos nije dobar, unesite broj");
                }
            }
        }

       
    }
}
