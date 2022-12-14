using System;
using System.Collections.Generic;
using System.Text;

namespace _2.Raiding
{
    public class Rogue : BaseHero
    {
        public Rogue(string name, int power) :
            base(name, 80)
        {
        }

        public override string CastAbility()
        {
            return $"Rogue - {Name} hit for {Power} damage";
        }
    }
}
