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
    public class ZeigeErgebnisSteps
    {
        private readonly TrackerDriver _driver;

        public ZeigeErgebnisSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [Then(@"zeigt.* (\d+) (Schlag|Schlaege)\.")]
        public void ZeigeErgebnis(int schlagzahl, string schlagnomen)
        {
            _driver.EmpfangeAnweisung(ZeigeErgebnisBefehl.ZEIGEERGEBNIS);
            _driver.AssertThatAntwortContains("{0}", schlagzahl);
        }
    }
}
