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
            return _interpreter.OperationFuer(kommando).FuehreAus(_scorecard);
        }

        public string Starte()
        {
            return _startoperation.FuehreAus(_scorecard);
        }
    }
}