using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TTDtestLibrary;

namespace TDDtestLibraryTest
{
    [TestClass]
    public class VoornamenTest
    {
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void VoornaamKanNietLeegZijn()
        {
            new Persoon(new List<string>() {string.Empty});

        }
        [TestMethod, ExpectedException(typeof(NullReferenceException))]
        public void VoornaamKanNietNULLZijn()
        {
            Persoon persoon = new Persoon(new List<string>() {null});
        }
        [TestMethod]
        public void EenPersoonKanMeerdereVoornamenHebben()
        {
            Persoon persoon = new Persoon(new List<String>() {"Klaas", "Jan", "Peter"});
            Assert.IsTrue(persoon.ToString() == "Klaas Jan Peter");
        }

        [TestMethod]
        public void EenPersoonKanEenVoornaamHebben()
        {
            Persoon persoon = new Persoon(new List<string>() {"Jan"});
            Assert.IsTrue(persoon.ToString() == "Jan");
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenVoornaamMagNietTweeKeerVoorkomen()
        {
            Persoon persoon = new Persoon(new List<string>() { "Jan", "Klaas", "Jan", "Peter"});
            
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void IedereVoornaamBestaatUitMinstensEenLetter()
        {
            Persoon persoon = new Persoon(new List<string>() { "Jan", "", "Bert" });
            Assert.IsTrue(persoon.ToString() == "Jan");
        }
        [TestMethod]
        public void ToStringWordtJuistWeergegeven()
        {
            Persoon persoon = new Persoon(new List<String>() { "Klaas", "Jan", "Peter" });
            Assert.IsTrue(persoon.ToString() == "Klaas Jan Peter");
        }
    }
}
