using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class SpielendeBefehl : Befehl
    {
        protected override string Kommando
        {
            get { return "Ende"; }
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
            get { return "beendet das Spiel."; }
        }
    }
}
