using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tabl;
            System.Collections.Generic.List<String> tablica = new List<string>();

            Console.WriteLine("Rozmiar {0}, Pojemność {1}", tablica.Count, tablica.Capacity);
            tablica.Add("aaa");
            tablica.Add("sss");
            Console.WriteLine("Rozmiar {0}, Pojemność {1}", tablica.Count, tablica.Capacity);

            tablica.Add("aaa");
            tablica.Add("sss");
            tablica.Add("aaa");
            tablica.Add("sss");
            tablica.Add("sss");
            Console.WriteLine("Rozmiar {0}, Pojemność {1}", tablica.Count, tablica.Capacity);

            tablica.Add("sss");
            tablica.Add("sss");
            Console.WriteLine("Rozmiar {0}, Pojemność {1}", tablica.Count, tablica.Capacity);
            tablica.TrimExcess();
            tablica[2] = "AAA";

            System.Collections.Generic.Queue<string> kolejkaFIFO = new Queue<string>();
            kolejkaFIFO.Enqueue("Coś");
            kolejkaFIFO.Enqueue("Coś dwa");

            foreach (var item in kolejkaFIFO)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(kolejkaFIFO.Dequeue());
            Console.WriteLine(kolejkaFIFO.Dequeue());




            Stack<string> stos = new Stack<string>();
            stos.Push("Baba Jaga"); //włożenie na stos
            stos.Push("Hogata");
            stos.Push("Teściowa");

            foreach (var item in stos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(stos.Pop());
            Console.WriteLine(stos.Pop());

            Dictionary<List<string>, string> slownik = new Dictionary<List<string>, string>();

            HashSet<string> x = new HashSet<string>();

            slownik.Add(tablica, "Jakiś napis");
            Console.WriteLine(slownik[tablica]);

            IEnumerable<object> ie = (IEnumerable<string>)stos;
            IEnumerator<object> ie2 = stos.GetEnumerator();


            Console.ReadKey();
        }

        static void Wypisz(IEnumerator<object> ie)
        {
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Current);
            }
        }
    }
}
