using System;

namespace NerdGolfTracker.Operationen
{
    public class Lochwechsel : IOperation
    {
        public string FuehreAus(IScorecard scorecard)
        {
            int schlagZahl = scorecard.AnzahlSchlaege;
            int parZahl = scorecard.ParZahl;
            string schlagWort = (schlagZahl == 1) ? "Schlag" : "Schlaege";
            if (schlagZahl > parZahl)
            {
                Console.WriteLine(string.Format("Du hattest {0} {1} ({2} ueber Par).", schlagZahl, schlagWort, schlagZahl - parZahl));
            }
            else if (schlagZahl < parZahl)
            {
                Console.WriteLine(string.Format("Du hattest {0} {1} ({2} unter Par).", schlagZahl, schlagWort, parZahl - schlagZahl));
            }
            else
            {
                Console.WriteLine(string.Format("Du hattest {0} {1} genau Par.", schlagZahl, schlagWort));
            }
            scorecard.SchliesseLochAb();
            return new Lochbegruessung().FuehreAus(scorecard);
        }
    }
}