using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class SpielendeBefehl : Befehl
    {
        public const string ENDE = "Ende";

        protected override string Kommando
        {
            get { return ENDE; }
        }

        public override IOperation Operation
        {
            get { return new Spielende(); }
        }

        protected override string Kuerzel
        {
            get { return "e"; }
        }
        protected override string Erklaerung
        {
            get { return NerdGolfTrackerResources.SpielendeBefehl_Erklaerung_beendet_das_Spiel_; }
        }
    }
}
