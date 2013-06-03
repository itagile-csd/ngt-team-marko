using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class HilfeBefehl : IBefehl
    {
        public string Kommando
        {
            get { return "Hilfe"; }
        }

        public IOperation Operation
        {
            get { return new Hilfe(); }
        }

        public string Erklaerung
        {
            get { return "zeigt Dir diese Erklaerung."; }
        }
    }
}