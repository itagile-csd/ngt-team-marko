using TechTalk.SpecFlow;

namespace AkzeptanzTests.Bindings
{
    [Binding]
    public class SchlaegeZaehlenSteps
    {
        private readonly TrackerDriver _driver;

        public SchlaegeZaehlenSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [Then(@"z�hlt.* (\d+) (Schlag|Schlaege)\.")]
        public void PruefeSchlagzahl(int schlagzahl, string schlagnomen)
        {
            _driver.AssertThatAntwortContains("{0}", schlagzahl);
            _driver.AssertThatAntwortContains("{0}", schlagnomen);
        }
    }
}