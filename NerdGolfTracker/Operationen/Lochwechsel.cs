namespace NerdGolfTracker.Operationen
{
    public class Lochwechsel : IOperation
    {
        public string FuehreAus(IScorecard scorecard)
        {
            scorecard.SchliesseLochAb();
            return new Lochbegruessung().FuehreAus(scorecard);
        }
    }
}