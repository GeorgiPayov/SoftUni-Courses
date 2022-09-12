using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class SimpleLayout : ILayout
    {
        public string Format
            => "{0} - {1} - {2}";

        public SimpleLayout()
        {
            string.Format(Format, "1", "2", "3");
        }


        //public SimpleLayout(string dateTime, Logger reportLevel, string message)
        //{
        //    this.DateTime = dateTime;
        //    this.ReportLevel = reportLevel;
        //    this.Message = message;
        //}
        //
        //public string DateTime { get; set; }
        //
        //public Logger ReportLevel { get; set; }
        //
        //public string Message { get; set; }
    }
}
