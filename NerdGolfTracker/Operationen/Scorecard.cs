using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdGolfTracker.Operationen
{
    public class Scorecard : IOperation
    {
        public string FuehreAus(IScorecard scorecard)
        {
            return scorecard.Print();
        }
    }
}
