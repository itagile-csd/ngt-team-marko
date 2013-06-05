using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class ScorecardBefehl : Befehl
    {
        public override IOperation Operation
        {
            get { return new Scorecard(); }
        }

        protected override string Erklaerung
        {
            get { return "druckt die Scorecard."; }
        }

        protected override string Kommando
        {
            get { return "Scorecard"; }
        }

        protected override string Kuerzel
        {
            get
            {
                return "sc";
            }
        }
    }
}
