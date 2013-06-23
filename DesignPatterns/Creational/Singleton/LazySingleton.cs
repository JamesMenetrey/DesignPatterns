/*
* DesignPatterns
* https://github.com/ZenLulz/DesignPatterns
*
* Copyright 2013 ZenLulz ~ Jämes Ménétrey
* Released under the MIT license
*/

using System;

namespace DesignPatterns.Creational.Singleton
{
    /// <summary>
    /// A lazy thread-safe implementation of singleton.
    /// The singleton pattern ensures a class has only one instance, and provide a global point of access to it.
    /// </summary>
    public sealed class LazySingleton
    {
        /// <summary>
        /// The thread-safe singleton. The object is created only when <see cref="Instance"/> is accessed.
        /// </summary>
        private static readonly Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(() => new LazySingleton());

        /// <summary>
        /// Public accessor to get the singleton.
        /// </summary>
        public static LazySingleton Instance
        {
            get { return _instance.Value; }
        }

        /// <summary>
        /// The constructor must be marked as private in order to prevent people to instance it using the new keyword.
        /// </summary>
        private LazySingleton()
        {
        }
    }
}
