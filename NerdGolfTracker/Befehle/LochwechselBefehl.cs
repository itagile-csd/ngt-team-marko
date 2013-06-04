using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class LochwechselBefehl : Befehl
    {
        protected override string Kommando
        {
            get { return "Naechstes Loch"; }
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
            get { return "bringt Dich zum naechsten Loch."; }
        }
    }

  
}