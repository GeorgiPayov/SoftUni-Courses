using SOLID.Appenders;
using SOLID.ReportLevel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) 
            : base (layout)
        {

        }

        public override void Append(string datetime, LogLevel reportLevel, string message)
        {
            string appendMessage = string.Format(this.Layout.Format, datetime, reportLevel, message);

            Console.WriteLine(appendMessage);
        }


        //public ConsoleAppender(ILayout apend)
        //{
        //    this.Apend = apend;
        //}
        //
        //public ILayout Apend { get; set; }
        //
        //public void Message()
        //{
        //    return Console.WriteLine($"{Apend.DateTime}, {Apend.ReportLevel}");
        //}
    }
}
