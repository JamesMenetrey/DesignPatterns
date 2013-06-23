/*
* DesignPatterns
* https://github.com/ZenLulz/DesignPatterns
*
* Copyright 2013 ZenLulz ~ Jämes Ménétrey
* Released under the MIT license
*/

namespace DesignPatterns.Creational.Singleton
{
    /// <summary>
    /// An very simple thread-safe implementation of singleton.
    /// The singleton pattern ensures a class has only one instance, and provide a global point of access to it.
    /// </summary>
    /// <remarks>
    /// For further details, read the article 'Implementing Singleton in C#' written by Microsoft: http://msdn.microsoft.com/en-us/library/ff650316.aspx
    /// </remarks>
    public sealed class SimpleSingleton
    {
        /// <summary>
        /// The thread-safe singleton. The object is created when any static members/functions of this class is called.
        /// </summary>
        public static readonly SimpleSingleton Instance = new SimpleSingleton();

        /// <summary>
        /// The constructor must be marked as private in order to prevent people to instance it using the new keyword.
        /// </summary>
        private SimpleSingleton()
        {
        }
    }
}
