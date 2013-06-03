using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class SchlagBefehl : IBefehl
    {
        public string Kommando
        {
            get { return "Schlage Ball"; }
        }

        public IOperation Operation
        {
            get { return new Schlag(); }
        }

        public string Erklaerung
        {
            get { return "zaehlt einen Schlag."; }
        }
    }
}