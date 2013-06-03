using Moq;
using NerdGolfTracker;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class TrackerTest
    {
        [Test]
        public void GibtErgebnisDerAusgeloestenOperationZurueck()
        {
            var interpreterStub = new Mock<IInterpreter>();
            var operationStub = new Mock<IOperation>();
            interpreterStub.Setup(interpreter => interpreter.OperationFuer("Eingabe"))
                .Returns(operationStub.Object);
            operationStub.Setup(operation => operation.FuehreAus(It.IsAny<IScorecard>()))
                .Returns("Ausgabe");
            var tracker = new Tracker(interpreterStub.Object, null, null);
            Assert.That(tracker.ReagiereAuf("Eingabe"), Is.EqualTo("Ausgabe"));
        }

        [Test]
        public void GibtErgebnisDerStartoperationZurueck()
        {
            var startoperationStub = new Mock<IOperation>();
            startoperationStub.Setup(operation => operation.FuehreAus(It.IsAny<IScorecard>()))
                .Returns("Ausgabe");
            var tracker = new Tracker(null, null, startoperationStub.Object);
            Assert.That(tracker.Starte(), Is.EqualTo("Ausgabe"));
        }
        [Test]
        public void UnknownOperation()
        {
            var mockInterpreter = new Mock<IInterpreter>();
            mockInterpreter.Setup(interpreter => interpreter.OperationFuer(It.IsAny<string>())).Returns(() => null);
            var tracker = new Tracker(mockInterpreter.Object, null, null);
          
            Assert.AreEqual(tracker.ReagiereAuf(""), "Unbekannter Befehl");
        }
    }
}