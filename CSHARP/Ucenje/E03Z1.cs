using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E03Z1
    {
        public static void Izvedi()
        {
            Console.Write("Unesite prvi cijeli broj: ");
            int broj1 = int.Parse(Console.ReadLine());

            Console.Write("Unesite drugi cijeli broj: ");
            int broj2 = int.Parse(Console.ReadLine());
            {
                Console.WriteLine("Uneseni brojevi su: {0} i {1}", broj1, broj2);

            }
            int zbroj = broj1 + broj2;
            int razlika = broj1 - broj2;

            Console.WriteLine("Zbroj je: {0}", zbroj);
            Console.WriteLine("Razlika je: {0}", razlika);

            int umnozak = broj1 * broj2;
            {
                Console.WriteLine("Umnozak je: {0} ", umnozak);
            }

            Console.Write("Unesite prvi broj: ");
            int broj3 = int.Parse(Console.ReadLine());
            Console.Write("Unesite drugi broj: ");
            int broj4 = int.Parse(Console.ReadLine());
            {
                Console.WriteLine("Uneseni brojevi su {0} i {1}", broj3, broj4);
            } 

            int kvadratbroj1 = broj3 * broj4;
            int kvadratbroj2 = broj3 * broj4;
            int zbrojkvadrata = kvadratbroj1 + kvadratbroj2;
            {
                Console.WriteLine("Zbroj kvadrata {0} i {1} je: {2}", kvadratbroj1, kvadratbroj2, zbrojkvadrata);
            }

            int kvocjent = broj3 / broj4;
            {
                Console.WriteLine("Kvocjent dva broja {0} i {1}: {2}", broj3, broj4, kvocjent);
            }
        }
        
       

    
    

    }
}
