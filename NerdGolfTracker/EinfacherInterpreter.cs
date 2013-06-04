using System.Collections.Generic;
using NerdGolfTracker.Befehle;

namespace NerdGolfTracker
{
    public class EinfacherInterpreter : IInterpreter
    {
        public IOperation OperationFuer(string kommando)
        {
            IOperation result = null;
            List<IBefehl> befehle = new AlleBefehle().Befehle();
            IBefehl befehl = befehle.Find(b => kommando == b.Kommando);
            if (befehl != null)
            {
                result = befehl.Operation;
            }
            return result;
        }
    }
}
