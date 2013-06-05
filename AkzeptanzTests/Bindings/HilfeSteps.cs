using TechTalk.SpecFlow;
using NerdGolfTracker;
using NerdGolfTracker.Befehle;

namespace AkzeptanzTests.Bindings
{
    [Binding]
    class HilfeSteps
    {
        private TrackerDriver _driver;

        public HilfeSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [When(@"ich die Hilfe aufrufe,")]
        public void RufeHilfeAuf()
        {
            _driver.EmpfangeAnweisung(HilfeBefehl.HILFE);
        }

        [Then(@"zeigt der NerdGolfTracker seine Benutzung an.")]
        public void PruefeHilfeZurBenutzung()
        {
            _driver.AssertThatAntwortContains("folgende Befehle");
        }

        [Then(@"erklärt der NerdGolfTracker das Kommando ""(.*)""\.")]
        public void PruefeHilfeZuKommando(string kommando)
        {
            _driver.AssertThatAntwortContains(kommando);
        }
    }
}
