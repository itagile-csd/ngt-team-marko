namespace NerdGolfTracker.Operationen
{
    public class Lochausgabe : IOperation
    {
        public string FuehreAus(IScorecard scorecard)
        {
            return string.Format("auf dem {0}.Loch", scorecard.Lochnummer);
        }
    }
}