using System.Collections.Generic;
using System.Text;

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

        public string Print()
        {
            var ergStr = new StringBuilder();
            foreach (var lochSchlag in m_SchlaegeProLoch)
            {
                string schlagName = "Schlag";
                if (lochSchlag.Value != 1)
                {
                    schlagName = "Schlaege";
                }
                ergStr.Append(string.Format("Loch {0}:\t{1} {2}\n", lochSchlag.Key, lochSchlag.Value, schlagName));
            }
            return ergStr.ToString();
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