using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linku1
{
    class Osoba
    {
        public string Imie { set; get; }
        public string Nazwisko { set; get; }
        public int Rok { set; get; }
        public decimal Pensja { set; get; }

        public static List<Osoba> Utworz()
        {
            return new List<Osoba>()
            {
                new Osoba() {Imie="Bob", Nazwisko="Budowniczy", Rok=1980, Pensja=4000},
                new Osoba() {Imie="Kubuś", Nazwisko="Puchatek", Rok=1936, Pensja=1000},
                new Osoba() {Imie="Kaczor", Nazwisko="Donald", Rok=1930, Pensja=3000},
                new Osoba() {Imie="Papa", Nazwisko="Smerf", Rok=1990, Pensja=5000},
                new Osoba() {Imie="Maja", Nazwisko="Pszczółka", Rok=1979, Pensja=7000},
                new Osoba() {Imie="Królewna", Nazwisko="Śnieżka", Rok=1910, Pensja=2000},
                new Osoba() {Imie="Jaga", Nazwisko="Baba", Rok=1780, Pensja=9000}
            };
        }
    }


    static class Rozszerzająca  //przypomnienie typów rozszerzających
    {
        public static double Jakas(this double x, double y)
        {
            return x * y; 
        }
    }

    class Program
    {

        
        static void Main(string[] args)
        {
            double a = 10;
            a.Jakas(2);

            var b = new
            {
                Pole1 = "staś",
                Pole2 = 40
            };

            Console.WriteLine("{0} {1}", b.Pole1, b.Pole2);
            Console.WriteLine(b.GetType().FullName);

            var osoby = Osoba.Utworz();

            var o1 = from o in osoby select o; //równoważne var o1 = osoby.Select(o => o);

            var o2 = osoby.Select(o => new
                {
                    Nazwa = o.Imie + " " + o.Nazwisko,
                    o.Pensja
                });

            foreach (var item in o2)
            {
                Console.WriteLine("{0} {1}", item.Nazwa, item.Pensja);
            }

            //lub równoważnie:
            //var o2 = from o in osoby
            //         select new
            //         {
            //             Nazwa = o.Imie + " " + o.Nazwisko,
            //             o.Pensja
            //         };

            foreach (var item in o2)
            {
                Console.WriteLine("{0} {1}", item.Nazwa, item.Pensja);
            }

            //Maksymalna pensja:
            var o3 = osoby.Where(o => o.Pensja == osoby.Max(q => q.Pensja));
            Osoba os = o3.FirstOrDefault();
            Console.WriteLine("{0} {1}", os.Imie, os.Nazwisko);

            Console.ReadKey();
        }
    }
}
