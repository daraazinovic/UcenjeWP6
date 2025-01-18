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

            int postotak1 = IzracunajPostotakImena(ime1);
            int postotak2 = IzracunajPostotakImena(ime2);

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

        private static int IzracunajPostotakImena(string ime)
        {
            int zbroj = 0;
            // Petlja za zbrajanje susjednih slova
            for (int i = 0; i < ime.Length - 1; i++)
            {
                zbroj += (int)ime[i] + (int)ime[i + 1];
            }
            //Ako je broj slova neparan dodajemo zadnje slovo
            if (ime.Length % 2 != 0)
            {
                zbroj += (int)ime[ime.Length - 1];
            }

            return zbroj % 101;
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
                    return unos.ToLower();
                }
                else
                {
                    Console.WriteLine("Unos smije sadržavati samo slova.");
                }
            }
        }

    }
        
            

        
    

}
  
    
       

          

