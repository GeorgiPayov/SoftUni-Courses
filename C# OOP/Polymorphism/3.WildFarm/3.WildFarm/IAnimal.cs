using System;
using System.Collections.Generic;
using System.Text;

namespace _3.WildFarm
{
    public interface IAnimal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        string ProduceSound();

        void Eat(IFood food);
    }
}
