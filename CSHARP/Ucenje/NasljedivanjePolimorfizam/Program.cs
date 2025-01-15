using System.ComponentModel.DataAnnotations;
using System.Text;


using Ucenje.E18NasljedivanjePolimorfizam;

namespace Ucenje.NasljedivanjePolimorfizam
{
    public class Program
    {

        public Program(string s)
        {
            Console.WriteLine(s);
            var smjer = new Smjer() { Sifra = 1, Naziv = "Web programiranje" };

            Console.WriteLine(smjer);

            var osoba = new Osoba() { Sifra = 1, Ime = "Pero", Prezime = "Perić" };

            osoba = new Osoba("Marija", "Zrinjska");

            Console.WriteLine(osoba);

            string s1 = "AA";

            Console.WriteLine(s1.GetHashCode());

            s1 = "BB";

            Console.WriteLine(s1.GetHashCode());

            var sb = new StringBuilder();

            sb.Append("AA");

            Console.WriteLine(sb.GetHashCode());

            sb.Clear().Append("BB");

            Console.WriteLine(sb.GetHashCode());


            Smjer smjer1 = new Smjer() { Naziv = "Web programiranje" };
            Smjer smjer2 = new Smjer() { Naziv = "Web programiranje" };

            Console.WriteLine(smjer1.GetHashCode());
            Console.WriteLine(smjer2.GetHashCode());

            Console.WriteLine(smjer.Equals(smjer2));


            //var e = new Entitet();
            //e.Sifra = 1;

            var e = new EntitetImpl() { Sifra = 1 };


            Obrada[] obrade = new Obrada[2];

            obrade[0] = new ObradaUlazniRacun();
            obrade[1] = new ObradaIzlazniRacun();


            foreach(Obrada o in obrade)
            {
                o.Procesuiraj();
            }
           
        }
    }
}
