using System;
using System.Collections;
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


        internal static decimal UcitajDecimalniBroj(string poruka, decimal min, decimal max)
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

        internal static string UcitajString(string stara, string poruka, int max, bool obavezno)
        {
            string s;
            while (true)
            {
                Console.Write(poruka + " (" + stara + "): ");
                s = Console.ReadLine().Trim();
                if (s.Length == 0)
                {
                    return stara;
                }
                if ((obavezno && s.Length == 0) || s.Length > max)
                {
                    Console.WriteLine("Unos obavezan, maksimalno dozvoljeno {0} znakova", max);
                    continue;
                }
                return s;
            }
        }

       

        internal static string UcitajString(string poruka, int max, bool obavezno, string StaraVrijednost)
        {
            string s;
            while (true)
            {
                Console.Write(poruka + "(" + StaraVrijednost + ") 0 za odustani" + ": ");
                s = Console.ReadLine().Trim();
                if (s == "0")
                {
                    return StaraVrijednost;
                }
                if ((obavezno && s.Length == 0) || s.Length > max)
                {
                    Console.WriteLine("Unos obavezan, maksimalno dozvoljeno {0} znakova", max);
                    continue;
                }
                return s;
            }

       
        }

        internal static void PrikaziPoruku(string v)
        {
            throw new NotImplementedException();
        }

        internal static string UcitajString(string v, string naziv)
        {
            Console.WriteLine(v);
            if (!string.IsNullOrEmpty(naziv))
            {
                Console.WriteLine($"Trenutna vrijednost: {naziv}");
            }

            string unos = Console.ReadLine();

            // Ako je unos prazan, vraćamo trenutnu vrijednost (ako postoji)
            if (string.IsNullOrEmpty(unos))
            {
                return naziv;
            }

            return unos;
        }
    }
}
