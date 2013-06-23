/*
* DesignPatterns
* https://github.com/ZenLulz/DesignPatterns
*
* Copyright 2013 ZenLulz ~ Jämes Ménétrey
* Released under the MIT license
*/

using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Behavioral.ChainOfResponsibility.Handlers;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    /// <summary>
    /// The chain of responsibility avoids coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.
    /// Chain the receiving objects and pass the request along the chain until an object handles it.
    /// </summary>
    public class SpamBlocker
    {
        private readonly List<ISpamHandler> _handlers = new List<ISpamHandler>();

        /// <summary>
        /// Set up the base filters.
        /// </summary>
        public SpamBlocker()
        {
            _handlers.Add(new WordHandler());
            _handlers.Add(new EmailHandler());
        }

        /// <summary>
        /// The user can add another filter if needed.
        /// </summary>
        public void AddSpamHandler(ISpamHandler handler)
        {
            _handlers.Add(handler);
        }

        /// <summary>
        /// The chain of responsibility is used here.
        /// </summary>
        public bool ShouldBlock(Email email)
        {
            return _handlers.Any(handler => handler.ShouldBlock(email));
        }
    }
}
