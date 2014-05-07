using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void kosztPrzejazduSamochod()
        {
            var kontekst = new RozliczeniePracownikow.Roliczenia();
            var aktualna = kontekst.kosztPrzejazduSamochod(900, 5.5F, 5.3F, 54.0F);
            var oczekiwana = 316.35F;

            Assert.AreNotEqual<double>(oczekiwana, aktualna);
        }

        [TestMethod]
        public void TestChorobowe()
        {
            var kontekst = new RozliczeniePracownikow.Roliczenia();
            var aktualna = kontekst.chorobowe(10, 3650.0F);
            var oczekiwana = 973.30M;

            Assert.AreEqual<decimal>(oczekiwana, aktualna);
        }
    }
}
