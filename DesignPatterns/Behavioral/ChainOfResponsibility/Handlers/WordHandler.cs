/*
* DesignPatterns
* https://github.com/ZenLulz/DesignPatterns
*
* Copyright 2013 ZenLulz ~ Jämes Ménétrey
* Released under the MIT license
*/

namespace DesignPatterns.Behavioral.ChainOfResponsibility.Handlers
{
    public class WordHandler : ISpamHandler
    {
        /// <summary>
        /// Very powerful word-based filter.
        /// </summary>
        public bool ShouldBlock(Email email)
        {
            return email.Content.Contains("Apple");
        }
    }
}
