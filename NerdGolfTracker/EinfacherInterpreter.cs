using System;
using System.Collections.Generic;
using System.Linq;

namespace NerdGolfTracker
{
    public class EinfacherInterpreter : IInterpreter
    {
        public IOperation OperationFuer(string kommando)
        {
            IOperation result = null;
            List<Befehl> befehle = new AlleBefehle().Befehle();
            IEnumerable<Befehl> zuständigeBefehle = befehle.FindAll(b => b.IstZustaendigFuer(kommando));
            if (zuständigeBefehle.Count() > 1)
            {
                throw new ArgumentException("Mehr als ein zuständiges Kommando gefunden " + kommando);    
            }

            Befehl befehl = zuständigeBefehle.FirstOrDefault();
            if (befehl != null)
            {
                result = befehl.Operation;
            }
            return result;
        }
    }
}
