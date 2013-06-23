/*
* DesignPatterns
* https://github.com/ZenLulz/DesignPatterns
*
* Copyright 2013 ZenLulz ~ Jämes Ménétrey
* Released under the MIT license
*/

using System.Diagnostics;

namespace DesignPatterns.Structural.Wrapper.Loggers
{
    /// <summary>
    /// An implementation of an simple logger.
    /// </summary>
    public class SimpleLogger
    {
        public void Log(string message, LogLevels level)
        {
            Debug.WriteLine("[{0}] {1}", level, message);
        }
    }

    public enum LogLevels
    {
        Debug,
        Error,
        Info,
        Warning,
    }
}
