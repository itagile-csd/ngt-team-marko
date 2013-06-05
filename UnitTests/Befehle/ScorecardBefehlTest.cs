using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NerdGolfTracker.Befehle;
using NerdGolfTracker.Operationen;

namespace UnitTests.Befehle
{
    [TestFixture]
    public class ScorecardBefehlTest
    {
        [Test]
        public void KommandoTest()
        {
            var befehl = new ScorecardBefehl();
            Assert.That(befehl.IstZustaendigFuer("Scorecard"));
        }

        [Test]
        public void OperationTest()
        {
            var befehl = new ScorecardBefehl();
            Assert.That(befehl.Operation, Is.InstanceOf(typeof(Scorecard)));
        }

        [Test]
        public void ErklaerungTest()
        {
            var befehl = new ScorecardBefehl();
            Assert.AreEqual(" * \"Scorecard (sc)\" druckt die Scorecard.", befehl.HilfeText);
        }
    }
}
