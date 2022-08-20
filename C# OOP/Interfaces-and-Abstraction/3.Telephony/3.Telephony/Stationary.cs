using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Telephony
{
    public class Stationary: ICalling
    {
        public Stationary(string number)
        {
            this.Number = number;
        }

        public string Number { get; set; }

        public string Calling()
        {
            return "Dialing...";
        }
    }
}
