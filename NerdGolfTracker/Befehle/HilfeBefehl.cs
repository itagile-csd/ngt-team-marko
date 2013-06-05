using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class HilfeBefehl : Befehl
    {
        public const string HILFE = "Hilfe";
        public const string ZEIGEERKLAERUNG = "zeigt Dir diese Erklaerung.";

        protected override string Kommando
        {
            get { return HILFE; }
        }

        public override IOperation Operation
        {
            get { return new Hilfe(); }
        }

        protected override string Kuerzel
        {
            get { return "h"; }
        }
        protected override string Erklaerung
        {
            get { return ZEIGEERKLAERUNG; }
        }
    }
}