using System.Collections.Generic;
using System.Text;
using NerdGolfTracker.Hilfsmittel;

namespace NerdGolfTracker
{
    public class EinfacheScorecard : IScorecard
    {
        public int AnzahlSchlaege { get { return m_SchlaegeProLoch[Lochnummer]; } }
        public int Lochnummer { get; private set; }
        public int GesamtSchlaege {
            get { return GetGesamtSchlaege(); }
        }
        public int ParZahl
        {
            get { return m_ParZahlProLoch[Lochnummer]; }
        }

        private IDictionary<int,int> m_SchlaegeProLoch;
        private IDictionary<int, int> m_ParZahlProLoch; 

        public EinfacheScorecard()
        {
            m_SchlaegeProLoch = new Dictionary<int, int>();
            m_SchlaegeProLoch.Add(1,0);
            Lochnummer = 1;
            m_ParZahlProLoch = new Dictionary<int, int>
                {
                    {1, 4},
                    {2, 5},
                    {3, 3},
                    {4, 4},
                    {5, 3},
                    {6, 4},
                    {7, 5},
                    {8, 4},
                    {9, 3},
                    {10, 5},
                    {11, 4},
                    {12, 5},
                    {13, 4},
                    {14, 3},
                    {15, 4},
                    {16, 4},
                    {17, 3},
                    {18, 5}
                };
        }

        public void SchliesseLochAb()
        {   
            Lochnummer++;
            m_SchlaegeProLoch.Add(Lochnummer,0);        
        }
        public void SchliesseSpielAb()
        {
            Geschlossen = true;
        }

        public bool Geschlossen { get; private set; }

        public void ErhoeheAnzahlSchlaege()
        {
            m_SchlaegeProLoch[Lochnummer]++;
        }

        public string Print()
        {
            var ergStr = new StringBuilder();
            
            foreach (var lochSchlag in m_SchlaegeProLoch)
            {
                ergStr.Append(string.Format("Loch {0:##}: {1}\n", lochSchlag.Key,  AusgabeErzeuger.Schlaege(lochSchlag.Value)));
            }
            string gesamtAusgabe = AusgabeErzeuger.GesamtErgebnis(GetGesamtSchlaege());
            ergStr.Append(AusgabeErzeuger.ErzeugeTrenner(gesamtAusgabe.Length));
            ergStr.Append("\n");
            ergStr.Append(gesamtAusgabe);

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