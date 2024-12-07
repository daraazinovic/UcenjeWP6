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

            Console.WriteLine("Uneseni brojevi su: {0} i {1}", broj1, broj2);


            int zbroj = broj1 + broj2;
            int razlika = broj1 - broj2;

            Console.WriteLine("Zbroj je: {0}", zbroj);
            Console.WriteLine("Razlika je: {0}", razlika);
        }
        
       
    }

}


