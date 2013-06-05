namespace NerdGolfTracker
{
    public interface IScorecard
    {
        int AnzahlSchlaege { get; }
        int Lochnummer { get; }
        int GesamtSchlaege { get; }
        string Print();
        void ErhoeheAnzahlSchlaege();
        void SchliesseLochAb();
        bool Geschlossen { get; }
        void SchliesseSpielAb();
    }
}