using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class ZeigeErgebnisBefehl : IBefehl
    {
        public string Kommando
        {
            get { return "Zeige Ergebnis"; }
        }

        public IOperation Operation
        {
            get { return new ZeigeErgebnis(); }
        }

        public string Erklaerung
        {
            get { return "zeigt das Gesamtergebnis an."; }
        }
    }
}