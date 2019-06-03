﻿using System;
using System.Reflection;
using System.Xml;
using NLog;
using NLog.Config;

namespace LogProject
{
    /// <summary>
    /// Log all stacktraces depending on their level : Info, Error, Fatal, Info, Warning.
    /// </summary>
    public class LogService : ILogService
    {
        private Logger logger;

        public void Initialize(Assembly assembly, string assemblyName)
        {
            var location = $"{assemblyName}.NLog.config";
            var stream = assembly.GetManifestResourceStream(location);
            LogManager.Configuration = new XmlLoggingConfiguration(XmlReader.Create(stream), null);
            this.logger = LogManager.GetCurrentClassLogger();
        }

        public void LogDebug(string message)
        {
            this.logger.Info(message);
        }

        public void LogError(string message)
        {
            this.logger.Error(message);
        }

        public void LogFatal(string message)
        {
            this.logger.Fatal(message);
        }

        public void LogInfo(string message)
        {
            this.logger.Info(message);
        }

        public void LogWarning(string message)
        {
            this.logger.Warn(message);
        }
    }
}
