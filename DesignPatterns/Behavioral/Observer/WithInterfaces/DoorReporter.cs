/*
* DesignPatterns
* https://github.com/ZenLulz/DesignPatterns
*
* Copyright 2013 ZenLulz ~ Jämes Ménétrey
* Released under the MIT license
*/

using System;

namespace DesignPatterns.Behavioral.Observer.WithInterfaces
{
    /// <summary>
    /// This is the observer implementation.
    /// The observer pattern defines a one-to-many dependency between objects where a state change in one object results in all its dependents being notified and updated automatically.
    /// This example uses the interfaces <see cref="IObservable{T}"/> and <see cref="IObserver{T}"/> provided by .NET Framework.
    /// </summary>
    public class DoorReporter : IObserver<Door>
    {
        /// <summary>
        /// Give a name to identify the observer.
        /// </summary>
        private readonly string _name;
        /// <summary>
        /// A reference to the observable (used for dispose).
        /// </summary>
        private IDisposable _observable;
        

        public DoorReporter(string name)
        {
            _name = name;
        }

        /// <summary>
        /// This method allows to subscribe from an observable component.
        /// </summary>
        /// <param name="observable"></param>
        public void Subscribe(IObservable<Door> observable)
        {
            if (observable != null)
                _observable = observable.Subscribe(this);
        }

        /// <summary>
        /// This method allows to unsubscribe from an observable component.
        /// </summary>
        public void Unsubscribe()
        {
            if(_observable != null)
                _observable.Dispose();
        }

        public void OnNext(Door value)
        {
            Console.WriteLine("{0}: The door '{1}' is {2}", _name, value.Name, value.IsOpened ? "opened" : "closed");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("{0}: The door state cannot be determined", _name);
        }

        public void OnCompleted()
        {
            Console.WriteLine("{0}: The observable object has completed transmitting data.", _name);
            Unsubscribe();
        }
    }
}
