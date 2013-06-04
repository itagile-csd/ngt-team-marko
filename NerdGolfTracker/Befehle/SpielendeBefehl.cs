using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class SpielendeBefehl : IBefehl
    {
        public string Kommando
        {
            get { return "Ende"; }
        }

        public IOperation Operation
        {
            get { return new Spielende(); }
        }

        public string Erklaerung
        {
            get { return "beendet das Spiel."; }
        }
    }
}
