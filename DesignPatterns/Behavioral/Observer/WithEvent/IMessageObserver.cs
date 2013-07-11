/*
* DesignPatterns
* https://github.com/ZenLulz/DesignPatterns
*
* Copyright 2013 ZenLulz ~ Jämes Ménétrey
* Released under the MIT license
*/
namespace DesignPatterns.Behavioral.Observer.WithEvent
{
    /// <summary>
    /// Defines how is an observer.
    /// </summary>
    public interface IMessageObserver
    {
        /// <summary>
        /// Used to subscribe to an observable.
        /// </summary>
        void Observe(IMessageObservable observable);
    }
}
