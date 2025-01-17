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
            // Učitavanje broja redaka i stupaca od korisnika
            int redovi = UcitajBrojRedaka("Unesi broj redaka: ");
            int stupci = UcitajBrojStupaca("Unesi broj stupaca: ");

            // Stvaranje 2D niza (matrice) za pohranu spiralnog poretka brojeva
            int[,] tablica = new int[redovi, stupci];

            // Inicijalizacija varijabli
            int vrijednost = 1; // Broj koji se upisuje u matricu
            int maxVrijednost = redovi * stupci; // Ukupan broj elemenata u matrici

            // Granice spirale
            int desnaGranica = stupci - 1;
            int donjaGranica = redovi - 1;
            int gornjaGranica = 0;
            int lijevaGranica = 0;

            // Glavna petlja koja popunjava matricu spiralno
            while (vrijednost <= maxVrijednost)
            {
                // 1. Potez: Desno -> Gore (Krećemo od donjeg desnog kuta)
                for (int stup = desnaGranica; stup >= lijevaGranica && vrijednost <= maxVrijednost; stup--)
                {
                    tablica[donjaGranica, stup] = vrijednost++;
                }
                donjaGranica--; // Smanjujemo donju granicu jer smo popunili zadnji redak

                // 2. Potez: Dolje -> Lijevo
                for (int redak = donjaGranica; redak >= gornjaGranica && vrijednost <= maxVrijednost; redak--)
                {
                    tablica[redak, lijevaGranica] = vrijednost++;
                }
                lijevaGranica++; // Povećavamo lijevu granicu jer smo popunili prvi stupac

                // 3. Potez: Lijevo -> Desno
                for (int stup = lijevaGranica; stup <= desnaGranica && vrijednost <= maxVrijednost; stup++)
                {
                    tablica[gornjaGranica, stup] = vrijednost++;
                }
                gornjaGranica++; // Povećavamo gornju granicu jer smo popunili prvi redak

                // 4. Potez: Gore -> Dolje
                for (int redak = gornjaGranica; redak <= donjaGranica && vrijednost <= maxVrijednost; redak++)
                {
                    tablica[redak, desnaGranica] = vrijednost++;
                }
                desnaGranica--; // Smanjujemo desnu granicu jer smo popunili zadnji stupac
            }

            // Ispis tablice množenja (glavna logika)
            for (int i = 1; i <= redovi; i++) // Iteriramo kroz retke tablice množenja
            {
                for (int j = 1; j <= stupci; j++) // Iteriramo kroz stupce tablice množenja
                {
                    int spiralniIndeks = 0;
                    // Pronalazimo odgovarajući broj (spiralni indeks) u popunjenoj matrici
                    for (int x = 0; x < redovi; x++)
                    {
                        for (int y = 0; y < stupci; y++)
                        {
                            //Provjeravamo ako je vrijednost u tablici jednaka poziciji u tablici množenja
                            if (tablica[x, y] == (i - 1) * stupci + j)
                            {
                                spiralniIndeks = tablica[x, y];
                                break; // Pronašli smo indeks, izlazimo iz unutarnje petlje
                            }
                        }
                        if (spiralniIndeks != 0) break; // Pronašli smo indeks, izlazimo iz vanjske petlje
                    }

                    int originalRedak = 0;
                    int originalStupac = 0;
                    for (int x = 0; x < redovi; x++)
                    {
                        for (int y = 0; y < stupci; y++)
                        {
                            if (tablica[x, y] == spiralniIndeks)
                            {
                                originalRedak = x + 1;
                                originalStupac = y + 1;
                                break;
                            }
                        }
                        if (originalRedak != 0) break;
                    }

                    // Ispisujemo umnožak originalnih indeksa (iz tablice množenja)
                    Console.Write(string.Format("{0,4}", originalRedak * originalStupac) + "\t");
                }
                Console.WriteLine();
            }
        }



        private static int UcitajBrojStupaca(string poruka)
        {
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    int broj = int.Parse(Console.ReadLine());
                    if (broj >= 3 && broj <= 20)
                    {
                        return broj;
                    }
                    else
                    {
                        Console.WriteLine("Minimalan broj stupaca je 3, a maksimalan 20!");
                    }

                }
                catch
                {
                    Console.WriteLine("Problem kod učitanja broja!");
                }
            }

        }

        private static int UcitajBrojRedaka(string poruka)
        {

            while (true)
            {
                Console.Write(poruka);
                try
                {
                    int broj = int.Parse(Console.ReadLine());
                    if (broj >= 3 && broj <= 20)
                    {
                        return broj;
                    }
                    else
                    {
                        Console.WriteLine("Minimalan broj redaka je 3, a maksimalan 20!");
                    }

                }
                catch
                {
                    Console.WriteLine("Problem kod učitanja broja!");
                }
            }










        }

    }

  
    
    

       

































































