/*
* DesignPatterns
* https://github.com/ZenLulz/DesignPatterns
*
* Copyright 2013 ZenLulz ~ Jämes Ménétrey
* Released under the MIT license
*/

namespace DesignPatterns.Behavioral.Visitor
{
    /// <summary>
    /// Interface defining a collection is browsable using a visitor.
    /// </summary>
    public interface IWordsBrowsable
    {
        void Browse(IWordsVisitor visitor);
    }
}
