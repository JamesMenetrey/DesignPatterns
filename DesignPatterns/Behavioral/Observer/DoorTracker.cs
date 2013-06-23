/*
* DesignPatterns
* https://github.com/ZenLulz/DesignPatterns
*
* Copyright 2013 ZenLulz ~ Jämes Ménétrey
* Released under the MIT license
*/

using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer
{
    /// <summary>
    /// This is the observable implementation.
    /// The observer pattern defines a one-to-many dependency between objects where a state change in one object results in all its dependents being notified and updated automatically.
    /// </summary>
    public class DoorTracker : IObservable<Door>
    {
        /// <summary>
        /// This is a collection storing all references of the observers.
        /// </summary>
        private readonly List<IObserver<Door>> _observers = new List<IObserver<Door>>();

        /// <summary>
        /// The only method of the <see cref="IObservable{t}"/> interface.
        /// The observers must call this method to subscribe to the observable.
        /// </summary>
        public IDisposable Subscribe(IObserver<Door> observer)
        {
            if(!_observers.Contains(observer))
                _observers.Add(observer);
            return new Unsubscriber(_observers, observer);
        }

        /// <summary>
        /// Here to notify a change.
        /// This method will iterate the observer collection and call a pre-defined method defined in the <see cref="IObserver{t}"/> interface.
        /// </summary>
        public void Notify(Door door)
        {
            if(door == null)
                _observers.ForEach(o => o.OnError(new Exception()));
            else
            {
                _observers.ForEach(o => o.OnNext(door));
            }
        }

        /// <summary>
        /// Here to notify the end of the tracking.
        /// </summary>
        public void EndTracking()
        {
            foreach (var observer in _observers.ToArray())
            {
                if (_observers.Contains(observer))
                    _observers.Remove(observer);
            }
        }
    }

    /// <summary>
    /// This class allows an observer to be disposed.
    /// </summary>
    public class Unsubscriber : IDisposable
    {
        private readonly List<IObserver<Door>> _observers;
        private readonly IObserver<Door> _observer;

        public Unsubscriber(List<IObserver<Door>> observers, IObserver<Door> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observers != null && _observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}
