using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegacjeGeneryczne
{
    class Program
    {

        delegate void Delegacja(string s);


        static void Main(string[] args)
        {
            Action<string, string> d = (p,q) => Console.WriteLine("Czy działa" + p + q); //jest to delegacja reprezentujące metody zwracające wartości typu void
            d("ala", "ma kota");

            Func<string, string> d2 = p => p.ToUpper();
            Console.WriteLine(d2("alssdupa"));

            Console.ReadKey();
        }
    }
}
