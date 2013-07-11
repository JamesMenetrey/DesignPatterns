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
    /// Declares a delegate that is invoked when a new message is coming.
    /// </summary>
    /// <param name="sender">The object that invokes the delegate.</param>
    /// <param name="args">The argument that contains the message.</param>
    public delegate void OnWriteHandler(object sender, MessageEventArgs args);

    /// <summary>
    /// This is the observer implementation.
    /// The observer pattern defines a one-to-many dependency between objects where a state change in one object results in all its dependents being notified and updated automatically.
    /// This example uses delegates and events.
    /// </summary>
    public class Observable : IMessageObservable
    {
        /// <summary>
        /// An event to allow observers to subscribe/unsubscribe.
        /// </summary>
        public event OnWriteHandler OnWrite;

        /// <summary>
        /// This function is used by the observable to raise an event with a given message.
        /// </summary>
        /// <param name="message">The message to communicate to the observers.</param>
        protected void RaiseOnWrite(string message)
        {
            // Check there is at least an observer subscribed
            if (OnWrite != null)
            {
                // Create an event args containing the message
                var eventArgs = new MessageEventArgs(message);
                // Fire the event
                OnWrite(this, eventArgs);
            }
        }

        /// <summary>
        /// This function allows worker classes to write something that can be signaled to observers.
        /// </summary>
        /// <param name="message">The message to log.</param>
        public void Write(string message)
        {
            // Here we can perform some tests before sending the message
            // Check if the message is not null or empty
            if (!string.IsNullOrEmpty(message))
            {
                // Send it
                RaiseOnWrite(message);
            }
        }
    }
}
