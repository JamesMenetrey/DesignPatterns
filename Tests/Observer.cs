/*
* DesignPatterns
* https://github.com/ZenLulz/DesignPatterns
*
* Copyright 2013 ZenLulz ~ Jämes Ménétrey
* Released under the MIT license
*/
using DesignPatterns.Behavioral.Observer.WithEvent;
using DesignPatterns.Behavioral.Observer.WithInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ObserverTests
    {
        [TestMethod]
        public void WithIntrerfaces()
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

        [TestMethod]
        public void WithEvent()
        {
            // Create our objects
            var observable = new Observable();
            var observer = new Observer();

            // Subscribe
            observer.Observe(observable);

            // Send a message
            observable.Write("Youhou !");

            // The message is now printed in the console
        }
    }
}
