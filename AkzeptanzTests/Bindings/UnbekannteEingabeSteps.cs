using System;
using TechTalk.SpecFlow;

namespace AkzeptanzTests.Bindings
{
    [Binding]
    public class UnbekannteEingabeSteps
    {
        private TrackerDriver _driver;

        [When(@"ich eine dem NerdGolfTracker unbekannte Eingabe mache,")]
        public void WennIchEineDemNerdGolfTrackerUnbekannteEingabeMache(TrackerDriver driver)
        {
            _driver = driver;
        }
        
        [Then(@"weist mich der Tracker auf die Hilfe hin\.")]
        public void DannWeistMichDerTrackerAufDieHilfeHin_()
        {
            _driver.EmpfangeAnweisung("hallo");
        }
    }
}
