using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04Z3
    {
        public static void Izvedi()
        {
            Console.Write("Unesi prvi cijeli broj: ");
            int broj1 = int.Parse(Console.ReadLine());

            Console.Write("Unesi drugi cijeli broj: ");
            int broj2 = int.Parse(Console.ReadLine());


            //int manjibroj = Math.Min(broj1, broj2);
            //Console.WriteLine("Manji broj je: {0}", manjibroj);

            Console.Write("Unesi treći cijeli broj: ");
            int broj3 = int.Parse(Console.ReadLine());

            int najmanjibroj = Math.Min(broj1, Math.Min( broj2, broj3));
            Console.WriteLine("Najmanji broj je {0}", najmanjibroj );


           




        }





    }
}
