using DesignPatterns.Creational.Singleton;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Singleton
    {
        [TestMethod]
        public void SimpleSingletonTests()
        {
            Assert.AreSame(SimpleSingleton.Instance, SimpleSingleton.Instance);
        }

        [TestMethod]
        public void LazySingletonTests()
        {
            Assert.AreSame(LazySingleton.Instance, LazySingleton.Instance);
        }
    }
}
