using System.Globalization;

namespace NerdGolfTracker.Operationen
{
    public class ZeigeErgebnis : IOperation
    {
        public string FuehreAus(IScorecard scorecard)
        {
            if (scorecard.GesamtSchlaege == 1)
            {
                return "Du hast insgesamt 1 Schlag ausgefuehrt.";
            }
            return "Du hast insgesamt " + scorecard.GesamtSchlaege.ToString(CultureInfo.InvariantCulture) + " Schlaege ausgefuehrt.";
        }
    }
}