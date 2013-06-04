using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class SchlagBefehl : Befehl
    {
        protected override string Kommando
        {
            get { return "Schlage Ball"; }
        }

        public override IOperation Operation
        {
            get { return new Schlag(); }
        }
        protected override string Kuerzel
        {
            get { return "sb"; }
        }
        protected override string Erklaerung
        {
            get { return "zaehlt einen Schlag."; }
        }
    }
}