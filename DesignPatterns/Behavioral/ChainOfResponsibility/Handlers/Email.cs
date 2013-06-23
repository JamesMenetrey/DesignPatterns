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
    /// A simple e-mail.
    /// </summary>
    public class Email
    {
        public string Sender { get; set; }
        public string Content { get; set; }
        public string[] Attachments { get; set; }
    }
}
