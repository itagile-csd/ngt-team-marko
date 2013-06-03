namespace NerdGolfTracker
{
    public interface IScorecard
    {
        int AnzahlSchlaege { get; }
        int Lochnummer { get; }

        void ErhoeheAnzahlSchlaege();
        void SchliesseLochAb();
    }
}