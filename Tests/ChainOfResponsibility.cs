using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.ChainOfResponsibility.Handlers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ChainOfResponsibility
    {
        [TestMethod]
        public void UsingBaseFilters()
        {
            var email = new Email
                            {
                                Sender = "zen@microsoft.com",
                                Content = "I really like this campany !",
                                Attachments = new[] { "apple.png" }
                            };
            var blocker = new SpamBlocker();
            Assert.AreEqual(false, blocker.ShouldBlock(email));

            email.Sender = "zen@apple.com";
            Assert.AreEqual(true, blocker.ShouldBlock(email));
        }

        [TestMethod]
        public void UsingExtendedFilters()
        {
            var email = new Email
            {
                Sender = "zen@microsoft.com",
                Content = "I really like this campany !",
                Attachments = new[] { "apple.png" }
            };
            var blocker = new SpamBlocker();
            blocker.AddSpamHandler(new AttachmentHandler());
            Assert.AreEqual(true, blocker.ShouldBlock(email));
        }
    }
}
