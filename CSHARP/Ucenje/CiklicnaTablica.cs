using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje;
namespace Ucenje
{
    internal class CiklicnaTablica
    {
        public static void Izvedi()
        {
            int velicina = 50; // Veličina tablice (broj redaka i stupaca)

            // Kreiranje tablice množenja
            int[,] tablica = new int[velicina, velicina];
            for (int i = 0; i < velicina; i++)
            {
                for (int j = 0; j < velicina; j++)
                {
                    tablica[i, j] = (i + 1) * (j + 1);
                }
            }

            // Postavljanje početnih koordinata i smjera
            int x = velicina / 2, y = velicina / 2;
            int smjer = 0; // 0: desno, 1: dolje, 2: lijevo, 3: gore

            // Popunjavanje spirale
            for (int i = 1; i <= velicina * velicina; i++)
            {
                Console.Write(tablica[x, y] + " ");

               
                
            }
        }
    }


}

    
    
   



