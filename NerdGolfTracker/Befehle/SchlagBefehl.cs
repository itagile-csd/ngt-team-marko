using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class SchlagBefehl : Befehl
    {
        public const string SCHLAGEBALL = "Schlage Ball";

        protected override string Kommando
        {
            get { return SCHLAGEBALL; }
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
            get { return NerdGolfTrackerResources.SchlagBefehl_Erklaerung_zaehlt_einen_Schlag_; }
        }
    }
}