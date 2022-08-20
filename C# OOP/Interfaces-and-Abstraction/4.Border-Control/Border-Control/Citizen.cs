using System;
using System.Collections.Generic;
using System.Text;

namespace Border_Control
{
    public class Citizen
    {
        public Citizen(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name { get; set; }

        public int Id { get; set; }
    }
}
