using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class GeneratorLozinki
    {
        public static void Izvedi()
        {
            //Console.WriteLine("Generator lozinki");

            int duljinaLozinke = UcitajBroj("Unesite duljinu lozinke: ", 1, 128); // Ograničenje duljine
            bool ukljuciVelikaSlova = UcitajBool("Uključiti velika slova? (da/ne): ");
            bool ukljuciMalaSlova = UcitajBool("Uključiti mala slova? (da/ne): ");
            bool ukljuciBrojeve = UcitajBool("Uključiti brojeve? (da/ne): ");
            bool ukljuciInterpunkciju = UcitajBool("Uključiti interpunkcijske znakove? (da/ne): ");
            bool pocinjeBrojem = UcitajBool("Lozinka počinje brojem? (da/ne): ");
            bool pocinjeInterpunkcijom = UcitajBool("Lozinka počinje interpunkcijom? (da/ne): ");
            bool zavrsavaBrojem = UcitajBool("Lozinka završava brojem? (da/ne): ");
            bool zavrsavaInterpunkcijom = UcitajBool("Lozinka završava interpunkcijom? (da/ne): ");
            bool ponavljajuciZnakovi = !UcitajBool("Lozinka ima ponavljajuće znakove? (da/ne): "); // Obrnuto logiku za lakšu upotrebu u kodu
            int brojLozinki = UcitajBroj("Unesite broj lozinki za generiranje: ", 1, 100); // Ograničenje broja lozinki

            for (int i = 0; i < brojLozinki; i++)
            {
                string lozinka = GenerirajJednuLozinku(duljinaLozinke, ukljuciVelikaSlova, ukljuciMalaSlova, ukljuciBrojeve, ukljuciInterpunkciju, pocinjeBrojem, pocinjeInterpunkcijom, zavrsavaBrojem, zavrsavaInterpunkcijom, ponavljajuciZnakovi);
                Console.WriteLine($"Lozinka {i + 1}: {lozinka}");
            }
        }

        private static string GenerirajJednuLozinku(int duljina, bool velika, bool mala, bool brojevi, bool interpunkcija, bool pocBroj, bool pocInterpunkcija, bool zavBroj, bool zavInterpunkcija, bool bezPonovljenih)
        {
            string znakovi = "";
            if (velika) znakovi += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (mala) znakovi += "abcdefghijklmnopqrstuvwxyz";
            if (brojevi) znakovi += "0123456789";
            if (interpunkcija) znakovi += "!@#$%^&*()_+-=[]{}|;':\",./<>?";

            if (string.IsNullOrEmpty(znakovi))
            {
                Console.WriteLine("Niste odabrali niti jedan skup znakova. Lozinka se ne može generirati.");
                return "";
            }

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] podaci = new byte[duljina];
                rng.GetBytes(podaci);

                StringBuilder lozinka = new StringBuilder(duljina);
                HashSet<char> iskoristeniZnakovi = new HashSet<char>();

                for (int i = 0; i < duljina; i++)
                {
                    int indeks;
                    char znak;

                    do
                    {
                        indeks = podaci[i] % znakovi.Length;
                        znak = znakovi[indeks];
                    } while (bezPonovljenih && iskoristeniZnakovi.Contains(znak));

                    if (bezPonovljenih) iskoristeniZnakovi.Add(znak);


                    lozinka.Append(znak);
                }

                //Provjere pocetka i kraja
                if (pocBroj && !char.IsDigit(lozinka[0]) && brojevi)
                {
                    lozinka[0] = znakovi[new Random().Next(znakovi.IndexOf('0'), znakovi.IndexOf('9'))];
                }
                if (pocInterpunkcija && !IsPunctuation(lozinka[0]) && interpunkcija)
                {
                    lozinka[0] = znakovi[new Random().Next(znakovi.IndexOf('!'), znakovi.Length - 1)];
                }
                if (zavBroj && !char.IsDigit(lozinka[duljina - 1]) && brojevi)
                {
                    lozinka[duljina - 1] = znakovi[new Random().Next(znakovi.IndexOf('0'), znakovi.IndexOf('9'))];
                }
                if (zavInterpunkcija && !IsPunctuation(lozinka[duljina - 1]) && interpunkcija)
                {
                    lozinka[duljina - 1] = znakovi[new Random().Next(znakovi.IndexOf('!'), znakovi.Length - 1)];
                }


                return lozinka.ToString();
            }
        }
        private static bool IsPunctuation(char c)
        {
            return "!@#$%^&*()_+-=[]{}|;':\",./<>?".Contains(c);
        }

        private static int UcitajBroj(string poruka, int min, int max)
        {
            while (true)
            {
                Console.Write(poruka);
                if (int.TryParse(Console.ReadLine(), out int broj) && broj >= min && broj <= max)
                {
                    return broj;
                }
                Console.WriteLine($"Unesite broj između {min} i {max}.");
            }
        }

        private static bool UcitajBool(string poruka)
        {
            while (true)
            {
                Console.Write(poruka);
                string unos = Console.ReadLine().ToLower();
                if (unos == "da") return true;
                if (unos == "ne") return false;
                Console.WriteLine("Unesite 'da' ili 'ne'.");
            }
        }

        
    }
    
}
