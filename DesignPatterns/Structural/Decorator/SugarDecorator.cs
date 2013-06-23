/*
* DesignPatterns
* https://github.com/ZenLulz/DesignPatterns
*
* Copyright 2013 ZenLulz ~ Jämes Ménétrey
* Released under the MIT license
*/

namespace DesignPatterns.Structural.Decorator
{
    /// <summary>
    /// The decorator pattern attaches additional responsibilities to an object dynamically keeping the same interface.
    /// Decorators provide a flexible alternative to subclassing for extending functionality.
    /// </summary>
    public class SugarDecorator
    {
        /// <summary>
        /// Reference to the drink.
        /// </summary>
        private readonly IDrink _drink;

        /// <summary>
        /// The drink is passed by parameter.
        /// </summary>
        public SugarDecorator(IDrink drink)
        {
            _drink = drink;
        }

        /// <summary>
        /// The number of ingredients increases !
        /// </summary>
        public string Ingredients
        {
            get { return _drink.Ingredients + ", Sugar"; }
        }
    }
}
