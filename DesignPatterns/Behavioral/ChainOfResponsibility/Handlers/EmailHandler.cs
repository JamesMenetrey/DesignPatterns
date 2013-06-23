/*
* DesignPatterns
* https://github.com/ZenLulz/DesignPatterns
*
* Copyright 2013 ZenLulz ~ Jämes Ménétrey
* Released under the MIT license
*/

namespace DesignPatterns.Behavioral.ChainOfResponsibility.Handlers
{
    /// <summary>
    /// A very powerful email-based filter.
    /// </summary>
    public class EmailHandler : ISpamHandler
    {
        public bool ShouldBlock(Email email)
        {
            return email.Sender.Contains("@apple.com");
        }
    }
}
