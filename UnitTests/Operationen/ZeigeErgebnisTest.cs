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
    class ZeigeErgebnisTest
    {
        [Test]
        public void EinLoch1SchlagExpectGesamtwert1()
        {
            var scorecardMock = new Mock<IScorecard>();
            scorecardMock.Setup(scorecard => scorecard.GesamtSchlaege).Returns(5);
            var ausgabe = new ZeigeErgebnis().FuehreAus(scorecardMock.Object);
            var zeilen = ausgabe.Split(' ');
            Assert.Contains("5", zeilen);
            //Assert.That(zeilen.Length, Is.EqualTo(4));
        }
    }
}
