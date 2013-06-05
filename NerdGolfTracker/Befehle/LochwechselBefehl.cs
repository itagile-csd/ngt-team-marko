using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class LochwechselBefehl : Befehl
    {
        public const string NAECHSTESLOCH = "Naechstes Loch";

        protected override string Kommando
        {
            get { return NAECHSTESLOCH; }
        }

        public override IOperation Operation
        {
            get { return new Lochwechsel(); }
        }

        protected override string Kuerzel
        {
            get { return "nl"; }
        }
        protected override string Erklaerung
        {
            get { return NerdGolfTrackerResources.LochwechselBefehl_Erklaerung_bringt_Dich_zum_naechsten_Loch_; }
        }
    }

  
}