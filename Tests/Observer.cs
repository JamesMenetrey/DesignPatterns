using System;
using DesignPatterns.Behavioral.Observer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Observer
    {
        [TestMethod]
        public void Tests()
        {
            var observable = new DoorTracker();

            var observer1 = new DoorReporter("Observer #1");
            observer1.Subscribe(observable);
            var observer2 = new DoorReporter("Observer #2");
            observer2.Subscribe(observable);

            var door = new Door("Small House");

            observable.Notify(door);
            door.IsOpened = true;
            observable.Notify(door);
            door.IsOpened = false;
            observable.Notify(door);
            observable.EndTracking();
        }
    }
}
