/*
* DesignPatterns
* https://github.com/ZenLulz/DesignPatterns
*
* Copyright 2013 ZenLulz ~ Jämes Ménétrey
* Released under the MIT license
*/
using DesignPatterns.Structural.Decorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Wrapper
    {
        [TestMethod]
        public void WrapperTests()
        {
            var coffee = new Coffee();
            var sugarCoffee = new SugarDecorator(coffee);
            Assert.AreEqual("Coffee, Sugar", sugarCoffee.Ingredients);

            var hotChocolate = new HotChocolate();
            var milkHotChocolate = new MilkDecorator(hotChocolate);
            Assert.AreEqual("Chocolate, Milk", milkHotChocolate.Ingredients);
        }
    }
}
