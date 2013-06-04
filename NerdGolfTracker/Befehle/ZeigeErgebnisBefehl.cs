using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class ZeigeErgebnisBefehl : Befehl
    {
        protected override string Kommando
        {
            get { return "Zeige Ergebnis"; }
        }

        public override IOperation Operation
        {
            get { return new ZeigeErgebnis(); }
        }

        protected override string Kuerzel
        {
            get { return "ze"; }
        }

        protected override string Erklaerung
        {
            get { return "zeigt das Gesamtergebnis an."; }
        }
    }
}