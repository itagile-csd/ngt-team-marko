namespace NerdGolfTracker.Operationen
{
    public class Schlagausgabe : Operation
    {
        public string FuehreAus(Scorecard scorecard)
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