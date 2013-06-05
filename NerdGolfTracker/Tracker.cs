namespace NerdGolfTracker
{
    public class Tracker
    {
        private IOperation _startoperation;
        private IScorecard _scorecard;
        private IInterpreter _interpreter;

        public Tracker(IInterpreter interpreter, IScorecard scorecard, IOperation startoperation)
        {
            _interpreter = interpreter;
            _scorecard = scorecard;
            _startoperation = startoperation;
        }

        public string ReagiereAuf(string kommando)
        {
            string result = "\"" + kommando + "\" ist kein zulaessiger Befehl, \"Hilfe\" zeigt alle Befehle.";

            IOperation operation = _interpreter.OperationFuer(kommando);
            if (operation != null)
            {
                result = operation.FuehreAus(_scorecard);
            }
            
            return result;
        }

        public bool Ende { get { return _scorecard.Geschlossen; } }

        public string Starte()
        {
            return _startoperation.FuehreAus(_scorecard);
        }
    }
}