using System;
using System.Collections.Generic;
using System.Text;

namespace _2.Raiding
{
    public class Paladin : BaseHero
    {
        public Paladin(string name, int power) : 
            base(name, 100)
        {
        }

        public override string CastAbility()
        {
            return $"Paladin - {Name} healed for {Power}";
        }
    }
}
