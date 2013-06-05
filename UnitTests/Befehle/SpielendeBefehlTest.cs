using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NerdGolfTracker;
using NerdGolfTracker.Befehle;
using NerdGolfTracker.Operationen;

namespace UnitTests.Befehle
{ 
    [TestFixture]
    public class SpielendeBefehlTest
    {
        [Test]
        public void KommandoTest()
        {
            var befehl = new SpielendeBefehl();
            Assert.IsTrue(befehl.IstZustaendigFuer(SpielendeBefehl.ENDE));
        }

        [Test]
        public void OperationTest()
        {
            var befehl = new SpielendeBefehl();
            Assert.That(befehl.Operation, Is.InstanceOf(typeof(Spielende)));
        }

        [Test]
        public void ErklaerungTest()
        {
            var befehl = new SpielendeBefehl();
            Assert.AreEqual(" * \"Ende (e)\" beendet das Spiel.", befehl.HilfeText);
        }
    }
}
