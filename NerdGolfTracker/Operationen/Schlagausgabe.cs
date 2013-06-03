namespace NerdGolfTracker.Operationen
{
    public class Schlagausgabe : IOperation
    {
        public string FuehreAus(IScorecard scorecard)
        {
            string type = "Schlaege";
            if (scorecard.AnzahlSchlaege == 1)
            {
                type = "Schlag";
            }
            return string.Format("{0} {1}", scorecard.AnzahlSchlaege, type);
        }
    }
}