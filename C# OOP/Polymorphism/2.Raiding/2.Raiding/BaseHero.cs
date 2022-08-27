using System;
using System.Collections.Generic;
using System.Text;

namespace _2.Raiding
{
    public abstract class BaseHero
    {
        protected BaseHero(string name, int power)
        {
            this.Name = name;
            this.Power = power;
        }

        public string Name { get; set; }
        public int Power { get; set; }

        public virtual string CastAbility()
        {
            return "";
        }
    }
}
