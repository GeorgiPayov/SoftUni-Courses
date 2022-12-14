using SOLID.LogFiles;
using SOLID.ReportLevel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SOLID.Appenders
{
    public class FileAppender : Appender
    {
        private const string FilePath = "../../../Output/result.txt";

        public FileAppender(ILayout layout, ILogFile logFile) 
            : base(layout)
        {
            this.LogFile = logFile;
        }

        public ILogFile LogFile { get; }

        public override void Append(string datetime, LogLevel reportLevel, string message)
        {
            string appendMessage = string.Format(this.Layout.Format, datetime, reportLevel, message);

            LogFile.Write(appendMessage);

            File.AppendAllText(FilePath, appendMessage + Environment.NewLine);
        }
    }
}
