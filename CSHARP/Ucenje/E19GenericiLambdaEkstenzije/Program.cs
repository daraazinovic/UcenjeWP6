﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E19GenericiLambdaEkstenzije
{
    public class Program
    {
        public Program()
        {
            Console.WriteLine("E19");

            List<int> brojevi = new List<int>();

            brojevi.Add(7);
            brojevi.Add(2);
            //brojevi.Add("2");

            Console.WriteLine(brojevi[1]);


            var gradovi = new List<string>();

            gradovi.Add("Osijek");
            gradovi.Add("Zadar");

            foreach(string grad in gradovi)
            {
                Console.WriteLine(grad);
            }

            var smjerovi = new List<Smjer>();
            smjerovi.Add(new() { Naziv = "Web programiranje" });
            smjerovi.Add(new() { Naziv = "Autolimar" });
            var s = new Smjer();
            s.Sifra = 1;
            s.Naziv = "Serviser";
            smjerovi.Add(s);

            Console.WriteLine(smjerovi[0].StariNaziv());

            var o = new Obrada<Smjer>();

            o.ObjektObrade = s;

            //var o1 = new Obrada<string>();

            //o1.ObjektObrade = "s";

            foreach(var smjer in smjerovi)
            {
                Console.WriteLine(smjer.Naziv);
            }

            smjerovi.Sort();

            Console.WriteLine("******************************");
            foreach (var smjer in smjerovi)
            {
                Console.WriteLine(smjer.Naziv);
            }

            smjerovi.Reverse();

            Console.WriteLine("******************************");
            foreach (var smjer in smjerovi)
            {
                Console.WriteLine(smjer.Naziv);
            }


            var datumi = new List<DateTime>();

            datumi.Add(new DateTime(1997, 10, 2));
            datumi.Add(DateTime.Now);

            foreach(var d in datumi)
            {
                Console.WriteLine(d);
            }


            // lambda izrazi

            Console.WriteLine(KlasicnaMedota(5,5));
            // => lambda

            var Zbroj = (int a, int b) => a + b;

            Console.WriteLine(Zbroj(5,5));

            var Algoritam = (int x, int y) =>
            {
                var z = 0;
                z = ++x;
                y += z;
                return x + y + z;
            };

            Console.WriteLine(Algoritam(2,3));


            var Parni = (int i) => i % 2 == 0;

            Console.WriteLine(Parni(7) ? "Parni" : "Neparni");


            //ekstenzije

            String ime = "Ana";

            Console.WriteLine(ime.LastOrDefault());

            Console.WriteLine(smjerovi.LastOrDefault());


            //korištenje vlastite ekstenzije
            s.Ispisi();

            var p = new Polaznik() { Sifra = 7, Ime = "Pero" };

            p.Ispisi();

            //zadnji krik ne OOP-a u OOP jeziku je definiranje on the fly

            var nesto = new
            {
                Ime = "Pero",
                Grad = "Osijek",
                Smjer = s
            };

            Console.WriteLine(nesto);
        }

        private int KlasicnaMedota(int a, int b)
        {
            return a + b;
        }
    }
}
