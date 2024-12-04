using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E03_Operatori
    {
        public static void Izvedi()
        {

            //Console.Whriteline("E03);
            //operatori za rad sa varijablama
            // = je dodjeljivanje vrijednosti
            //== provjera jednakosti->bool

            int i = 7; // tada zamislimo da je korisnik unio 7

            Console.WriteLine(i==6);

            int k = 2, l = 1;

            Console.WriteLine(l/k);

            Console.WriteLine(l/(float)k);

            Console.WriteLine(i!=k);

            Console.WriteLine("5%2={0}", 5 % 2);

            Console.WriteLine("4%2={0}", 4 % 2);

            int b = 0;
            b = b + 1;

            b += 1;

            b++;

            Console.WriteLine(b);


            b = 0;

            Console.WriteLine(b++);

            Console.WriteLine(++b);

            int t = 0, c = 1;
            t = c++ + t;
            c += --t;
            Console.WriteLine(c+t);


        }
    }
}
