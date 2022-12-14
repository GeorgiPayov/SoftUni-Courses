using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Layouts
{
    public class XmlLayout : ILayout
    {
        public string Format
            => @"
<log>
    <date>{0}</date>
    <level>{1}</level>
    <message>{2}</message>
</log>";
        
        public XmlLayout()
        {
            string.Format(Format, "1", "2", "3");
        }
    }
}
