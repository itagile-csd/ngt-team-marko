using System.Globalization;

namespace NerdGolfTracker.Operationen
{
    public class ZeigeErgebnis : IOperation
    {
        public string FuehreAus(IScorecard scorecard)
        {
            return scorecard.Print();
        }
    }
}