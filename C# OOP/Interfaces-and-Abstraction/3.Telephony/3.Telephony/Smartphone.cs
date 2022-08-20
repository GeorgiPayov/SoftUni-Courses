using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Telephony
{
    public class Smartphone: ICalling, IBrowsing
    {
        public Smartphone(string item)
        {
            this.Item = item;
        }

        public string Item { get; set; }

        public string Calling()
        {
            return "Calling...";
        }

        public string Browsing()
        {
            return "Browsing:";
        }
    }
}
