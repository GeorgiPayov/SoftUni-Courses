using System;
using System.Collections.Generic;
using System.Text;

namespace _3.WildFarm
{
    public abstract class Feline : Mammal
    {
        protected Feline(string name, double weight, int foodEaten, string livingRegion, string breed)
            : base(name, weight, foodEaten, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get; set; }
    }
}
