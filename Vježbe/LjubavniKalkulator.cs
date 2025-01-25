using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class LjubavniKalkulator
    {
        public static void Izvedi()
        {


            string ime1 = UcitajIme("Unesite prvo ime: ");
            string ime2 = UcitajIme("Unesite drugo ime: ");

            int postotak1 = IzracunajPostotakImena(ime1, 0, 0); // Poziv rekurzivne metode
            int postotak2 = IzracunajPostotakImena(ime2, 0, 0); // Poziv rekurzivne metode

            int ukupniPostotak = (postotak1 + postotak2) / 2;

            Console.WriteLine($"\n{ime1} ima {postotak1}% 'ljubavi'.");
            Console.WriteLine($"{ime2} ima {postotak2}% 'ljubavi'.");
            Console.WriteLine($"\n{ime1} i {ime2} imaju {ukupniPostotak}% kompatibilnosti (čisto iz zabave!).");

            //Dodatni "komentar" ovisno o postotku 
            if (ukupniPostotak < 30)
            {
                Console.WriteLine("Malo je tu ljubavi u zraku...");
            }
            else if (ukupniPostotak < 60)
            {
                Console.WriteLine("Ima potencijala, ali treba se potruditi.");
            }
            else if (ukupniPostotak < 80)
            {
                Console.WriteLine("Dobra veza, nastavite tako!");
            }
            else
            {
                Console.WriteLine("Prava ljubav!");
            }
        }

        private static int IzracunajPostotakImena(string ime, int indeks, int zbroj)
        {
            // Baza rekurzije: ako smo došli do kraja imena (ili pretposljednjeg znaka)
            if (indeks >= ime.Length - 1)
            {
                if (ime.Length % 2 != 0 && indeks < ime.Length)
                {
                    zbroj += (int)ime[indeks];
                }
                return zbroj % 101;
            }

            // Rekurzivni korak: zbroji trenutni i sljedeći znak i pozovi metodu za sljedeći indeks
            zbroj += (int)ime[indeks] + (int)ime[indeks + 1];
            return IzracunajPostotakImena(ime, indeks + 2, zbroj); // Pozivamo funkciju sa indeksom + 2 jer zbrajamo dva slova odjednom
        }

        private static string UcitajIme(string poruka)
        {
            while (true)
            {
                Console.Write(poruka);
                string unos = Console.ReadLine();

                if (string.IsNullOrEmpty(unos))
                {
                    Console.WriteLine("Unos ne smije biti prazan.");
                    continue;
                }

                bool samoSlova = unos.All(char.IsLetter);
                if (samoSlova)
                {
                    return unos.ToUpper();
                }
                else
                {
                    Console.WriteLine("Unos smije sadržavati samo slova.");
                }
            }


        }

    }
        
            

        
    

}
  
    
       

          

