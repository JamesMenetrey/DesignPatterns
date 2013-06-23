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
    /// Define a hot cholocate.
    /// </summary>
    public class HotChocolate : IDrink
    {
        /// <summary>
        /// For a simple hot cholocate, we just need... chocolate !
        /// </summary>
        public string Ingredients
        {
            get { return "Chocolate"; }
        }
    }
}
