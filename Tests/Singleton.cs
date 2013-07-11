/*
* DesignPatterns
* https://github.com/ZenLulz/DesignPatterns
*
* Copyright 2013 ZenLulz ~ Jämes Ménétrey
* Released under the MIT license
*/
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
