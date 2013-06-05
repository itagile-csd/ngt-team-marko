using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AkzeptanzTests.Bindings
{
    [Binding]
    public class ScorecardSteps
    {
        private TrackerDriver _driver;

        public ScorecardSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [When(@".*ich Scorecard aufrufe,")]
        public void RufeScorecardAuf()
        {
            _driver.EmpfangeAnweisung("Scorecard");
        }

        
        [Then(@".* Ball.* schlage.*")]
        public void SchlageBall()
        {
            _driver.EmpfangeAnweisung("Schlage Ball");
        }

        [Then(@"druckt der NerdGolfTracker die Scorecard.")]
        public void PruefeDruckergebnis()
        {
            _driver.AssertThatAntwortContains("Loch");
        }
    }
}
