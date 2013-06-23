/*
* DesignPatterns
* https://github.com/ZenLulz/DesignPatterns
*
* Copyright 2013 ZenLulz ~ Jämes Ménétrey
* Released under the MIT license
*/

using System;

namespace DesignPatterns.Creational.Factory.Loggers
{
    /// <summary>
    /// A logger implementation using Console API.
    /// </summary>
    public class ConsoleLogger :ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
