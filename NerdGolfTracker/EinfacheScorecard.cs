using System.Collections.Generic;

namespace NerdGolfTracker
{
    public class EinfacheScorecard : Scorecard
    {
        public int AnzahlSchlaege { get; private set; }
        public int Lochnummer { get; private set; }

        private IDictionary<int,int> m_SchlaegeProLoch; 

        public EinfacheScorecard()
        {
            m_SchlaegeProLoch = new Dictionary<int, int>();
            Lochnummer = 1;
        }

        public void SchliesseLochAb()
        {
            m_SchlaegeProLoch[Lochnummer] = AnzahlSchlaege;
            Lochnummer++;
            AnzahlSchlaege = 0;
        }

        public void ErhoeheAnzahlSchlaege()
        {
            AnzahlSchlaege++;
        }
    }
}