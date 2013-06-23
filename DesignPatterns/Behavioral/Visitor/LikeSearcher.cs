/*
* DesignPatterns
* https://github.com/ZenLulz/DesignPatterns
*
* Copyright 2013 ZenLulz ~ Jämes Ménétrey
* Released under the MIT license
*/

using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Visitor
{
    /// <summary>
    /// An search algorithme.
    /// </summary>
    public class LikeSearcher : IWordsVisitor
    {
        private readonly string _word;
        private readonly List<string> _matches = new List<string>();

        public LikeSearcher(string word)
        {
            _word = word;
        }

        public IEnumerable<string> Matches
        {
            get { return _matches.AsReadOnly(); }
        } 

        public void Visit(string word)
        {
            // If the word contains _word (like)
            if(word.Contains(_word))
                _matches.Add(word);
        }
    }
}
