using System;
using System.Collections.Generic;
using System.Linq;

namespace NerdGolfTracker
{
    class AlleBefehle
    {
        public List<Befehl> Befehle()
        {
            var befehlstyp = typeof (Befehl);
            var alleBefehlstypen = 
                GetType().Assembly.GetTypes().Where(befehlstyp.IsAssignableFrom);
            var alleKonkretenBefehlstypen = alleBefehlstypen.Except(new[] { befehlstyp }).ToList();
            List<Befehl> result = alleKonkretenBefehlstypen.ConvertAll(b => Activator.CreateInstance(b) as Befehl);
            List<Befehl> result1 = new List<Befehl>();

            result1.Add( result.Find(b => b.IstZustaendigFuer("nl")));
            result1.Add( result.Find(b => b.IstZustaendigFuer("h")));
            foreach (var befehl in result1)
            {
                result.Remove(befehl);
            }
            
            
            foreach (var befehl in result)
            {
                result1.Add(befehl);
            }
            
            return result1;
        }
    }
}
