using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public interface ILogger
    {

        public List<IAppender> Appenders { get; }

        void Info(string datetime, string message);

        void Warning(string datetime, string message);

        void Error(string datetime, string message);

        void Critical(string datetime, string message);

        void Fatal(string datetime, string message);

        //public string Warning()
        //{
        //    return "Warning";
        //}
        //
        //public string Error()
        //{
        //    return "Error";
        //}
        //
        //public string Info()
        //{
        //    return "Info";
        //}
    }
}
