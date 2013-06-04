


using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NerdGolfTracker;

namespace UnitTests
{
    [TestClass]
    public class BefehlsTest
    {
        private class TestBefehl : Befehl
        {
            private string MyKuerzel { get; set; }
 
            public TestBefehl()
            {
                MyKuerzel = string.Empty;
            }
            public TestBefehl(string kuerzel)
            {
                MyKuerzel = kuerzel;
            }
            protected override string Kuerzel
            {
                get { return MyKuerzel; }
            }
            protected override string Kommando
            {
                get { return "Kommando"; }
            }

            public override IOperation Operation
            {
                get { return null; }
            }

            protected override string Erklaerung
            {
                get { return "Eine Hilfe"; }
            }
        }

        [TestMethod]
        public void ZustaendigkeitOhneKuerzelTest()
        {
            Befehl sut = new TestBefehl();
            Assert.IsTrue(sut.IstZustaendigFuer("Kommando"));
        }

        [TestMethod]
        public void HilfeOhneKuerzelTest()
        {
            Befehl sut = new TestBefehl();
            Assert.AreEqual(" * \"Kommando\" Eine Hilfe", sut.HilfeText);
        }


        [TestMethod]
        public void ZustaendigkeitMitKuerzelTest()
        {
            Befehl sut = new TestBefehl("km");
            Assert.IsTrue(sut.IstZustaendigFuer("Kommando"));
        }

        [TestMethod]
        public void ZustaendigkeitMitKuerzelTest2()
        {
            Befehl sut = new TestBefehl("km");
            Assert.IsTrue(sut.IstZustaendigFuer("km"));
        }

        [TestMethod]
        public void ZustaendigkeitNegativeTest()
        {
            Befehl sut = new TestBefehl("km");
            Assert.IsFalse(sut.IstZustaendigFuer("FalschesKommand"));
        }

        [TestMethod]
        public void HilfeMitKuerzelTest()
        {
            Befehl sut = new TestBefehl("km");
            Assert.AreEqual(" * \"Kommando (km)\" Eine Hilfe", sut.HilfeText);
        }


    }
}
