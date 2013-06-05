using System;
using NUnit.Framework;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;
using NerdGolfTracker.Befehle;

namespace UnitTests
{
    [TestFixture]
    class EinfacherInterpreterTest
    {

        [TestCase(LochwechselBefehl.NAECHSTESLOCH, typeof(Lochwechsel))]
        [TestCase(SchlagBefehl.SCHLAGEBALL, typeof(Schlag))]
        [TestCase(HilfeBefehl.HILFE, typeof(Hilfe))]
        [TestCase(ZeigeErgebnisBefehl.ZEIGEERGEBNIS, typeof(ZeigeErgebnis))]
        [TestCase(SpielendeBefehl.ENDE, typeof(Spielende))]
        public void FindetOperation(string kommando, Type operationstyp)
        {
            IInterpreter interpreter = new EinfacherInterpreter();
            Assert.That(interpreter.OperationFuer(kommando), Is.InstanceOf(operationstyp));
        }

        [Test]
        public void UnknownInput()
        {
            IInterpreter interpreter = new EinfacherInterpreter();
            Assert.DoesNotThrow(()=> interpreter.OperationFuer(""));

        }
    }
}
