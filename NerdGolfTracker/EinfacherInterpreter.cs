using System.Collections.Generic;
using NerdGolfTracker.Befehle;

namespace NerdGolfTracker
{
    public class EinfacherInterpreter : IInterpreter
    {
        public IOperation OperationFuer(string kommando)
        {
            List<IBefehl> befehle = new AlleBefehle().Befehle();
            return befehle.Find(befehl => kommando == befehl.Kommando).Operation;
        }
    }
}
