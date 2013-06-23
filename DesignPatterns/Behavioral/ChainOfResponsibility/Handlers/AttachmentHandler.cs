/*
* DesignPatterns
* https://github.com/ZenLulz/DesignPatterns
*
* Copyright 2013 ZenLulz ~ Jämes Ménétrey
* Released under the MIT license
*/

using System.Linq;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.Handlers
{
    /// <summary>
    /// A very powerful attachment-based filter.
    /// </summary>
    public class AttachmentHandler : ISpamHandler
    {
        public bool ShouldBlock(Email email)
        {
            return email.Attachments.Any(attachment => attachment.Contains("apple.png"));
        }
    }
}
