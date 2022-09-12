using SOLID.ReportLevel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Appenders
{
    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ILayout Layout { get; }

        public LogLevel ReportLevel { get; set; }

        public abstract void Append(string datetime, LogLevel reportLevel, string message);
       
    }
}
