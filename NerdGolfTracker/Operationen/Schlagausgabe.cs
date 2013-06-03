namespace NerdGolfTracker.Operationen
{
    public class Schlagausgabe : IOperation
    {
        public string FuehreAus(IScorecard scorecard)
        {
            return string.Format("{0} Schlag", scorecard.AnzahlSchlaege);
        }
    }
}