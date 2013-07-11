/*
* DesignPatterns
* https://github.com/ZenLulz/DesignPatterns
*
* Copyright 2013 ZenLulz ~ Jämes Ménétrey
* Released under the MIT license
*/
using System;

namespace DesignPatterns.Behavioral.Observer.WithEvent
{
    /// <summary>
    /// This is the observer implementation.
    /// The observer pattern defines a one-to-many dependency between objects where a state change in one object results in all its dependents being notified and updated automatically.
    /// This example uses delegates and events.
    /// </summary>
    public class Observer : IMessageObserver
    {
        /// <summary>
        /// Subscribes to an observable.
        /// </summary>
        public void Observe(IMessageObservable observable)
        {
            // The observer subscribes here
            observable.OnWrite += OnWriteRaised;
        }

        /// <summary>
        /// Invoked when a message is submitted.
        /// </summary>
        public void OnWriteRaised(object sender, MessageEventArgs args)
        {
            Console.WriteLine("I observed a new message at {0}: {1}", args.Time, args.Message);
        }
    }
}
