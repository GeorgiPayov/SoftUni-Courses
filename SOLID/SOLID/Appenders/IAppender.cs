using SOLID.ReportLevel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public interface IAppender
    {
        public ILayout Layout { get; }

        public LogLevel ReportLevel { get; set; }

        void Append(string datetime, LogLevel reportLevel, string message);

        //public ILayout Apend { get; set; }
    }
}
