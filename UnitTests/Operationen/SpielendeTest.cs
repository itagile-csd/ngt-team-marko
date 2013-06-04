using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using NUnit.Framework;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests.Operationen
{
    [TestFixture]
    public class SpielendeTest
    {
        [Test]
        public void Spielende()
        {
            var scorecard = new Mock<IScorecard>();
            scorecard.Setup(sc => sc.AnzahlSchlaege).Returns(0);
            Assert.That(new Spielende().FuehreAus(scorecard.Object), Is.EqualTo("Das Spiel ist beendet. Du hattest 0 Schlaege."));
        }
    }
}
