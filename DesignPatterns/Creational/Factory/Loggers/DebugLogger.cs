/*
* DesignPatterns
* https://github.com/ZenLulz/DesignPatterns
*
* Copyright 2013 ZenLulz ~ Jämes Ménétrey
* Released under the MIT license
*/

using System.Diagnostics;


namespace DesignPatterns.Creational.Factory.Loggers
{
    /// <summary>
    /// A logger implementation using Debug API.
    /// </summary>
    public class DebugLogger :ILogger
    {
        public void Log(string message)
        {
            Debug.WriteLine(message);
        }
    }
}
