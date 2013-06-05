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
            scorecardMock.Setup(scorecard => scorecard.Print()).Returns("Printed");
            var ausgabe = new ZeigeErgebnis().FuehreAus(scorecardMock.Object);
            Assert.AreEqual(ausgabe, "Printed");
            
        }
    }
}
