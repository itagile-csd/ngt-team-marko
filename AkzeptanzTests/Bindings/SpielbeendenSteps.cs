using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdGolfTracker;
using NerdGolfTracker.Befehle;
using TechTalk.SpecFlow;

namespace AkzeptanzTests.Bindings
{
    [Binding]
    public class SpielbeendenSteps
    {
        private TrackerDriver _driver;

        public SpielbeendenSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [When(@"ich das Spiel beende,")]
        public void RufeEndeAuf()
        {
            _driver.EmpfangeAnweisung(SpielendeBefehl.ENDE);
        }

        [Then(@"wird der NerdGolfTracker beendet\.")]
        public void DannWirdDerNerdGolfTrackerBeendet()
        {
            _driver.AssertThatAntwortContains("beendet");
        }
    }
}
