/*
* DesignPatterns
* https://github.com/ZenLulz/DesignPatterns
*
* Copyright 2013 ZenLulz ~ Jämes Ménétrey
* Released under the MIT license
*/

namespace DesignPatterns.Structural.Wrapper
{
    /// <summary>
    /// Define an interface with provide an API we decide to implement in our code.
    /// </summary>
    interface ILogger
    {
        void Log(string message);
        void LogDebug(string message);
    }
}
