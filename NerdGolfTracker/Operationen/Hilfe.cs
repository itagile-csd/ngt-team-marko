using System.Collections.Generic;
using NerdGolfTracker.Befehle;

namespace NerdGolfTracker.Operationen
{
    public class Hilfe : IOperation
    {
        public string FuehreAus(IScorecard scorecard)
        {
            var hilfstexte = new AlleBefehle().Befehle().ConvertAll(HilfstextFuer);
            return "Ich helfe dir beim Fuehren der Scorecard. Ich reagiere auf folgende Befehle: " +
                   string.Join(System.Environment.NewLine, hilfstexte)
                   + ".";
        }

        private string HilfstextFuer(IBefehl befehl)
        {
            return string.Format(" * \"{0}\" {1}", befehl.Kommando, befehl.Erklaerung);
        }
    }
}