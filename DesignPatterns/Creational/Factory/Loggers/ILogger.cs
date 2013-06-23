/*
* DesignPatterns
* https://github.com/ZenLulz/DesignPatterns
*
* Copyright 2013 ZenLulz ~ Jämes Ménétrey
* Released under the MIT license
*/

namespace DesignPatterns.Creational.Factory.Loggers
{
    /// <summary>
    /// Define an interface for all logger components.
    /// </summary>
    public interface ILogger
    {
        void Log(string message);
    }
}
