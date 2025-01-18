using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class CiklicnaTablica
    {
        public static void Izvedi()
        {
            int redovi = UcitajBroj("Unesite broj redaka: ");
            int stupci = UcitajBroj("Unesite broj stupaca: ");

            if (redovi <= 0 || stupci <= 0)
            {
                Console.WriteLine("Broj redaka i stupaca mora biti veći od 0.");
                return;
            }

            int[,] tablica = new int[redovi, stupci];
            int broj = 1;
            int maxBroj = redovi * stupci;

            int gornjaGranica = 0;
            int donjaGranica = redovi - 1;
            int lijevaGranica = 0;
            int desnaGranica = stupci - 1;

            while (broj <= maxBroj)
            {
                // 1. Gore -> Lijevo (POČETAK U DONJEM DESNOM KUTU I SMJER KAZALJKE NA SATU)
                for (int j = desnaGranica; j >= lijevaGranica && broj <= maxBroj; j--)
                {
                    tablica[donjaGranica, j] = broj++;
                }
                donjaGranica--;

                // 2. Dolje -> Gore
                for (int i = donjaGranica; i >= gornjaGranica && broj <= maxBroj; i--)
                {
                    tablica[i, lijevaGranica] = broj++;
                }
                lijevaGranica++;

                // 3. Lijevo -> Desno
                for (int j = lijevaGranica; j <= desnaGranica && broj <= maxBroj; j++)
                {
                     tablica[gornjaGranica, j] = broj++;
                }

                gornjaGranica++;

                // 4. Gore -> Dolje
                for (int i = gornjaGranica; i <= donjaGranica && broj <= maxBroj; i++)
                {
                    tablica[i, desnaGranica] = broj++;
                }
                desnaGranica--;
            }

            // Ispis tablice
            Console.WriteLine("\nCiklicna tablica:");
            for (int i = 0; i < redovi; i++)
            {
                for (int j = 0; j < stupci; j++)
                {
                    Console.Write(String.Format("{0,4}", tablica[i, j]) + "\t");
                }
                Console.WriteLine();
            }
        }

        private static int UcitajBroj(string poruka)
        {
            while (true)
            {
                Console.Write(poruka);
                if (int.TryParse(Console.ReadLine(), out int broj) && broj > 0)
                {
                    return broj;
                }
                Console.WriteLine("Unesite pozitivan cijeli broj.");
            }
        }

        

    }
    
    
    
       
}
