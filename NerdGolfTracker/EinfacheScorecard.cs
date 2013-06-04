using System.Collections.Generic;

namespace NerdGolfTracker
{
    public class EinfacheScorecard : IScorecard
    {
        public int AnzahlSchlaege { get { return m_SchlaegeProLoch[Lochnummer]; } }
        public int Lochnummer { get; private set; }
        public int GesamtSchlaege {
            get { return GetGesamtSchlaege(); }
        }

        private IDictionary<int,int> m_SchlaegeProLoch; 

        public EinfacheScorecard()
        {
            m_SchlaegeProLoch = new Dictionary<int, int>();
            m_SchlaegeProLoch.Add(1,0);
            Lochnummer = 1;
        }

        public void SchliesseLochAb()
        {   
            Lochnummer++;
            m_SchlaegeProLoch.Add(Lochnummer,0);        
        }

        public void ErhoeheAnzahlSchlaege()
        {
            m_SchlaegeProLoch[Lochnummer]++;
        }

        private int GetGesamtSchlaege()
        {
            int gesamtSchlaege = 0;
            foreach (var i in m_SchlaegeProLoch)
            {
                gesamtSchlaege += i.Value;
            }

            return gesamtSchlaege;
        }
    }
}