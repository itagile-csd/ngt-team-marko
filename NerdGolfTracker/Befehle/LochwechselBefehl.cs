using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class LochwechselBefehl : IBefehl
    {
        public string Kommando
        {
            get { return "Naechstes Loch"; }
        }

        public IOperation Operation
        {
            get { return new Lochwechsel(); }
        }

        public string Erklaerung
        {
            get { return "bringt Dich zum naechsten Loch."; }
        }
    }
}