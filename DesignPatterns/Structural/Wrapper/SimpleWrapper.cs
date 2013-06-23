/*
* DesignPatterns
* https://github.com/ZenLulz/DesignPatterns
*
* Copyright 2013 ZenLulz ~ Jämes Ménétrey
* Released under the MIT license
*/

using DesignPatterns.Structural.Wrapper.Loggers;

namespace DesignPatterns.Structural.Wrapper
{
    /// <summary>
    /// The wrapper pattern (also known as adapter pattern) converts the interface of a class into another interface clients expect.
    /// An adapter lets classes work together that could not otherwise because of incompatible interfaces.
    /// The enterprise integration pattern equivalent is the translator.
    /// </summary>
    public class SimpleWrapper : ILogger
    {
        /// <summary>
        /// Encapsulates the logger in a private member var.
        /// </summary>
        private readonly SimpleLogger _logger = new SimpleLogger();

        /// <summary>
        /// Wraps the info log.
        /// </summary>
        public void Log(string message)
        {
            _logger.Log(message, LogLevels.Info);
        }

        /// <summary>
        /// Wraps the debug log.
        /// </summary>
        public void LogDebug(string message)
        {
            _logger.Log(message, LogLevels.Debug);
        }
    }
}
