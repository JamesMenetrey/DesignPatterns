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
    /// Define a coffee.
    /// </summary>
    public class Coffee : IDrink
    {
        /// <summary>
        /// For a simple coffee, we just need... coffee !
        /// </summary>
        public string Ingredients
        {
            get { return "Coffee"; }
        }
    }
}
