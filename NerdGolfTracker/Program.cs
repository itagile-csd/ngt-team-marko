using System;
using NerdGolfTracker.Operationen;

namespace NerdGolfTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var tracker = new Tracker(new EinfacherInterpreter(),
                                      new EinfacheScorecard(),
                                      new Lochbegruessung());
            Console.WriteLine(tracker.Starte());
            
            while (!tracker.Ende)
            {
                var befehl = Console.ReadLine();
                Console.WriteLine(tracker.ReagiereAuf(befehl));
            }
        }
    }
}
