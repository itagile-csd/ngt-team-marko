using System;
using System.Collections.Generic;
using System.Linq;

namespace NerdGolfTracker
{
    class AlleBefehle
    {
        public List<IBefehl> Befehle()
        {
            var befehlstyp = typeof (IBefehl);
            var alleBefehlstypen = 
                GetType().Assembly.GetTypes().Where(befehlstyp.IsAssignableFrom);
            var alleKonkretenBefehlstypen = alleBefehlstypen.Except(new[] { befehlstyp }).ToList();
            return alleKonkretenBefehlstypen.ConvertAll(b => Activator.CreateInstance(b) as IBefehl);
        }
    }
}
