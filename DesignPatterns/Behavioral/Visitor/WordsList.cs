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
    /// Define a type of collection based on <see cref="List{t}"/>.
    /// The visitor patterns represents an operation to be performed on the elements of an object structure.
    /// Visitor lets you define a new operation without changing the classes of the elements on which it operates.
    /// </summary>
    public class WordsList : List<string>, IWordsBrowsable
    {
        public WordsList(IEnumerable<string> words) : base(words)
        {
        }

        /// <summary>
        /// Lets a visitor to browse the collection.
        /// </summary>
        public void Browse(IWordsVisitor visitor)
        {
            foreach (var word in this)
            {
                visitor.Visit(word);
            }
        }
    }
}
