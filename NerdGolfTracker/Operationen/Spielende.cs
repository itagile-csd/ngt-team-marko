using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdGolfTracker.Operationen
{
    public class Spielende : IOperation
    {
        public string FuehreAus(IScorecard scorecard)
        {
            string result = string.Format("Das Spiel ist beendet. Du hattest {0} Schlaege.", scorecard.GesamtSchlaege);
            if (scorecard.GesamtSchlaege == 1)
            {
                result = string.Format("Das Spiel ist beendet. Du hattest 1 Schlag.");
            }
            scorecard.SchliesseSpielAb();
            return result;
        }
    }
}
