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
    class ScorecardTest
    {
        [Test]
        public void TestScorcardOperation()
        {
            string scPrintResult = "Scorecard print result";
            var scorecardMock = new Mock<IScorecard>();
            scorecardMock.Setup(sc => sc.Print()).Returns(scPrintResult);
            Assert.That(new Scorecard().FuehreAus(scorecardMock.Object),Is.EqualTo(scPrintResult));
        }
    }
}
