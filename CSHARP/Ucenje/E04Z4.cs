using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04Z4
    {
        public static void Izvedi()
        {
            string Slavonija = "Osijek";
            
            if (Slavonija == "Osijek")
            {
                Console.WriteLine("Slavonija");
            }
            else
            {
                Console.WriteLine("Ne znam koja je to regija"); 
            }


            string Dalmacija = "Zadar";

            if (Dalmacija == "Zadar")
            {
                Console.WriteLine("Dalmacija");
            }
            else
            {
                Console.WriteLine("Ne znam koja je to regija"); 
            }


            string Međimurje = "Čakovec";

            if (Međimurje == "Čakovec")
            {
                Console.WriteLine("Međimurje");
            }
            else
            {
                Console.WriteLine("Ne znam koja je to regija"); 
            }


            string Istra = "Pula";

            if (Istra == "Pula")
            {
                Console.WriteLine("Istra");
            }
            else
            {
                Console.WriteLine("Ne znam koja je to regija"); 
            }


            string Osjećkobaranjska = "Đakovo";

            switch (Osjećkobaranjska)
            {
                case string:
                    Console.WriteLine("Osječko baranjaska ");
                    break;
                default:
                    Console.WriteLine("Ne znam koja je to regija");
                    break;
            }


            string Vukovarskosrijemska = "Vinkovci";

            switch (Vukovarskosrijemska)
            {
                case string:
                    Console.WriteLine("Vukovarsko srijemska");
                    break;
                default:
                    Console.WriteLine("Ne znam koja je to regija");
                    break;
            }


            string Zagrebačka = "Velika Gorica";

            switch (Zagrebačka)
            {
                case string:
                    Console.WriteLine("Zagrebačka");
                    break;
                default:
                    Console.WriteLine("Ne znam koja je to regija");
                    break;
            }
        }

    }

}






