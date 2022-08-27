using System;
using System.Collections.Generic;
using System.Text;

namespace _2.Raiding
{
    public class Druid : BaseHero
    {
        public Druid(string name, int power) :
            base(name, 80)
        {
        }

        public override string CastAbility()
        {
            return $"Druid - {Name} healed for {Power}";
        }
    }
}
