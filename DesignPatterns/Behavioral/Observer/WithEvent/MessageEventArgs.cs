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
    /// This class is passed to the observers to provide information about the message.
    /// </summary>
    public class MessageEventArgs : EventArgs
    {
        /// <summary>
        /// The message.
        /// </summary>
        public string Message { get; protected set; }
        /// <summary>
        /// The time of the post.
        /// </summary>
        public DateTime Time { get; protected set; }

        /// <summary>
        /// The constructor.
        /// </summary>
        public MessageEventArgs(string message)
        {
            // Set the message
            Message = message;
            // Set the time to now
            Time = DateTime.Now;
        }
    }
}
