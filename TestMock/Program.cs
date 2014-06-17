using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMock
{

    [NUnit.Framework.TestFixture]
    class Program
    {
        static void Main(string[] args)
        {
            
            //komentarz testowy


            //Console.WriteLine(rozliczeniaMock.kosztPrzejazduSamochod(1000, 10F, 5F, 50F));
            //Console.ReadLine();
        }
        [NUnit.Framework.Test]
        public void testKosztPrzejazduSamochod()
        {
            var mocks = new Rhino.Mocks.MockRepository(); //tworzymy nowe repozytorium fałszowania 
            var rozliczeniaMock = mocks.StrictMock<RozliczeniePracownikow.Roliczenia>();
            Rhino.Mocks.Expect.Call(rozliczeniaMock.kosztPrzejazduSamochod(1000, 10F, 5F, 50F)).Return(100.00); //sfałszowanie wyniku metody
            mocks.ReplayAll(); //wdrożenie mocków
            NUnit.Framework.Assert.AreEqual(100, rozliczeniaMock.kosztPrzejazduSamochod(1000, 10F, 5F, 50F));
        }
    }

}
