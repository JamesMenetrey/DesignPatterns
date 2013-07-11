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
    /// Defines how a message can be observable.
    /// </summary>
    public interface IMessageObservable
    {
        /// <summary>
        /// The observers can be subscribe to this event.
        /// </summary>
        event OnWriteHandler OnWrite;
    }
}
