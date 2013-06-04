using System;
using NUnit.Framework;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests
{
    [TestFixture]
    class EinfacherInterpreterTest
    {

        [TestCase("Naechstes Loch", typeof(Lochwechsel))]
        [TestCase("Schlage Ball", typeof(Schlag))]
        [TestCase("Hilfe", typeof(Hilfe))]
        [TestCase("Spielende", typeof(Spielende))]
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
