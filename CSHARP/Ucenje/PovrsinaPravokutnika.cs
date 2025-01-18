using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class PovrsinaPravokutnika
    {
        public static void Izvedi()
        {
            // Console.WriteLine("Povrsina pravokutnika");

            Console.WriteLine("Unesi širinu pravokutnika: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi visinu pravokutnika: ");
            int b = int.Parse(Console.ReadLine());

            int povrsina = a * b; 
            Console.WriteLine("Površina pravokutnika je: {0} ", povrsina);
        }
    }
}
