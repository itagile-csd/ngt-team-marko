namespace NerdGolfTracker.Operationen
{
    public class Schlag : IOperation
    {
        public string FuehreAus(IScorecard scorecard)
        {
            scorecard.ErhoeheAnzahlSchlaege();
            return string.Format("Du hast {0} {1}.",
                new Schlagausgabe().FuehreAus(scorecard),
                new Lochausgabe().FuehreAus(scorecard));
        }
    }
}