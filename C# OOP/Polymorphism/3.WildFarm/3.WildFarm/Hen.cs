using System;
using System.Collections.Generic;
using System.Text;

namespace _3.WildFarm
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, int foodEaten, double wingSize)
            : base(name, weight, foodEaten, wingSize)
        {
        }

        public override string ProduceSound()
            => "Cluck";

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }

        public override void Eat(IFood food)
        {

            FoodEaten += food.Quantity;
            Weight += food.Quantity * 0.35;
        }
    }
}
