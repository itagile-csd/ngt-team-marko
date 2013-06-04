using System.Globalization;

namespace NerdGolfTracker.Operationen
{
    public class ZeigeErgebnis : IOperation
    {
        public string FuehreAus(IScorecard scorecard)
        {
            return "Du hast insgesamt " + scorecard.GesamtSchlaege.ToString(CultureInfo.InvariantCulture) + " Schlaege ausgefuehrt.";
        }
    }
}