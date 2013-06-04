using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class HilfeBefehl : Befehl
    {
        protected override string Kommando
        {
            get { return "Hilfe"; }
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
            get { return "zeigt Dir diese Erklaerung."; }
        }
    }
}