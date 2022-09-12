using SOLID.ReportLevel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class Logger : ILogger
    {
        public Logger(params IAppender[] appenders)
        {
            this.Appenders = new List<IAppender>();
            this.Appenders.AddRange(appenders);
        }

        public List<IAppender> Appenders { get; }


        public void Critical(string datetime, string message)
        {
            Log(datetime, LogLevel.Critical, message);
        }

        public void Error(string datetime, string message)
        {
            Log(datetime, LogLevel.Error, message);
        }

        public void Fatal(string datetime, string message)
        {
            Log(datetime, LogLevel.Fatal, message);
        }

        public void Info(string datetime, string message)
        {
            Log(datetime, LogLevel.Info, message);
        }

        public void Warning(string datetime, string message)
        {
            Log(datetime, LogLevel.Warning, message);
        }

        private void Log(string datetime, LogLevel logLevel, string message)
        {
            foreach (var appender in Appenders)
            {
                if (logLevel >= appender.ReportLevel)
                {
                    appender.Append(datetime, logLevel, message);
                }       
            }
        }
    }
}
