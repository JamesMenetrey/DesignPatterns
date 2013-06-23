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
    /// Interface defining a way to visit a word.
    /// </summary>
    public interface IWordsVisitor
    {
        void Visit(string word);
    }
}
