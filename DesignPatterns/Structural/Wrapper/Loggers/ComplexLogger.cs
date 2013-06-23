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
    /// An implementation of a complex logger.
    /// </summary>
    public class ComplexLogger
    {
        public void WriteDebug(string message)
        {
            Debug.WriteLine("[Debug] {0}", message);
        }

        public void WriteError(string message)
        {
            Debug.WriteLine("[Error] {0}", message);
        }

        public void WriteInfo(string message)
        {
            Debug.WriteLine("[Info] {0}", message);
        }

        public void WriteWarning(string message)
        {
            Debug.WriteLine("[Warning] {0}", message);
        }
    }
}
