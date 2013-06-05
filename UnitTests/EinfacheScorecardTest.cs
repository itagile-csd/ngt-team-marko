using System.Text;
using NUnit.Framework;
using NerdGolfTracker;
using NerdGolfTracker.Hilfsmittel;

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
            Assert.That(ergebnis.Contains("Loch 1: 1 Schlag"));
        }


        [Test]
        public void SimplePattern()
        {
            Assert.AreEqual("Gesamt: 1", AusgabeErzeuger.ErzeugeAusgabe(AusgabeErzeuger.s_GesamtErgebnisPattern, 1));
        }
        [Test]
        public void SimpleTrenner()
        {
            Assert.AreEqual("===", AusgabeErzeuger.ErzeugeTrennPattern("=",3));
        }

        [Test]
        public void PrintScoreCardGesamtErgebnis()
        {
            string ergebnis = _scorecard.Print();
            
            string erwartet = AusgabeErzeuger.ErzeugeAusgabe(AusgabeErzeuger.s_GesamtErgebnisPattern, 0);
            Assert.That(ergebnis.Contains(erwartet));
        }


        [Test]
        public void PrintScoreCardTrenner()
        {
            string ergebnis = _scorecard.Print();
            int erwarteteTrennerLaenge =
                AusgabeErzeuger.ErzeugeAusgabe(AusgabeErzeuger.s_GesamtErgebnisPattern, 0).Length;
            string erwartet = AusgabeErzeuger.ErzeugeTrennPattern(AusgabeErzeuger.s_Trennzeichen, erwarteteTrennerLaenge);
            Assert.That(ergebnis.Contains(erwartet));
        }



        [Test]
        public void PrintScorecardZweiSchlaege()
        {
            _scorecard.ErhoeheAnzahlSchlaege();
            _scorecard.ErhoeheAnzahlSchlaege();
            string ergebnis = _scorecard.Print();
                                        
            Assert.That(ergebnis.Contains("Loch 1: 2 Schlaege\n"));
        }

        [Test]
        public void EndeTest()
        {
            _scorecard.SchliesseSpielAb();
            Assert.IsTrue(_scorecard.Geschlossen);
        }

    }
}