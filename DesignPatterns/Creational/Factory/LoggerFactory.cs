/*
* DesignPatterns
* https://github.com/ZenLulz/DesignPatterns
*
* Copyright 2013 ZenLulz ~ Jämes Ménétrey
* Released under the MIT license
*/

using DesignPatterns.Creational.Factory.Loggers;

namespace DesignPatterns.Creational.Factory
{
    /// <summary>
    /// The factory pattern defines an interface for creating a single object, but let subclasses decide which class to instantiate.
    /// Factory Method lets a class defer instantiation to subclasses
    /// </summary>
    public static class LoggerFactory
    {
        /// <summary>
        /// Creates a new logger of a pre-defined type but returns an interface.
        /// Thus, the factory offers a loosely-coupled with the real type of the logger.
        /// </summary>
        public static ILogger Create()
        {
            return new DebugLogger();
        }
    }
}
