namespace NerdGolfTracker.Operationen
{
    public class Lochbegruessung : IOperation
    {
        public string FuehreAus(IScorecard scorecard)
        {
            return string.Format("Du bist jetzt {0}.", new Lochausgabe().FuehreAus(scorecard));
        }
    }
}