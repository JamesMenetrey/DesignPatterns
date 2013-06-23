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
    /// Interface defining a method used to block spam.
    /// </summary>
    public interface ISpamHandler
    {
        bool ShouldBlock(Email email);
    }
}
