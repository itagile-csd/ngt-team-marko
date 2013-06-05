using NUnit.Framework;
using NerdGolfTracker;

namespace UnitTests
{
    [TestFixture]
    public class EinfacheScorecardTest
    {
        private IScorecard _scorecard;

        [SetUp]
        public void InitialisiereScorecard()
        {
            _scorecard = new EinfacheScorecard();
        }

        [Test]
        public void InkrementiertSchlagzahlEinmal()
        {
            _scorecard.ErhoeheAnzahlSchlaege();
            Assert.That(_scorecard.AnzahlSchlaege, Is.EqualTo(1));
        }

        [Test]
        public void InkrementiertSchlagzahlMehrmals()
        {
            _scorecard.ErhoeheAnzahlSchlaege();
            _scorecard.ErhoeheAnzahlSchlaege();
            Assert.That(_scorecard.AnzahlSchlaege, Is.EqualTo(2));
        }

        [Test]
        public void ErhoehtLochnummerBeiLochwechsel()
        {
            _scorecard.SchliesseLochAb();
            Assert.That(_scorecard.Lochnummer, Is.EqualTo(2));
        }

        [Test]
        public void SchlagzahlBeiNeuemLochIstNull()
        {
            _scorecard.ErhoeheAnzahlSchlaege();
            _scorecard.SchliesseLochAb();
            Assert.That(_scorecard.AnzahlSchlaege, Is.EqualTo(0));
        }

        [Test]
        public void BerechneErgebnisEinfach()
        {
            _scorecard.ErhoeheAnzahlSchlaege();
            _scorecard.ErhoeheAnzahlSchlaege();
            Assert.AreEqual(2, _scorecard.GesamtSchlaege);
        }

        [Test]
        public void PrintScorecardEinSchlag()
        {
            _scorecard.ErhoeheAnzahlSchlaege();
            string ergebnis = _scorecard.Print();
            Assert.That(ergebnis.Contains("Loch 1:\t1 Schlag"));
        }

        [Test]
        public void PrintScorecardZweiSchlaege()
        {
            _scorecard.ErhoeheAnzahlSchlaege();
            _scorecard.ErhoeheAnzahlSchlaege();
            string ergebnis = _scorecard.Print();
            Assert.That(ergebnis.Contains("Loch 1:\t2 Schlaege"));
        }

    }
}