using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class ZeigeErgebnisBefehl : Befehl
    {
        public const string ZEIGEERGEBNIS = "Zeige Ergebnis";

        protected override string Kommando
        {
            get { return ZEIGEERGEBNIS; }
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
            get { return NerdGolfTrackerResources.ZeigeErgebnisBefehl_Erklaerung_zeigt_das_Gesamtergebnis_an_; }
        }
    }
}