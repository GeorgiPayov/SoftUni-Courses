using System;
using System.Collections.Generic;
using System.Text;

namespace _3.WildFarm
{
    public abstract class Bird : Animal
    {
        protected Bird(string name, double weight, int foodEaten, double wingSize) 
            : base(name, weight, foodEaten)
        {
            this.WingSize = wingSize;
        }

        public double WingSize { get; set; }
    }
}
