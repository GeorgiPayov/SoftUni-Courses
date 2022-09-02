using System;
using System.Collections.Generic;
using System.Text;

namespace _3.WildFarm
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, int foodEaten, string livingRegion) 
            : base(name, weight, foodEaten, livingRegion)
        {
        }

        public override string ProduceSound()
            => "Squeak";

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }

        public override void Eat(IFood food)
        {
            if (food is Fruit || food is Vegetable)
            {
                FoodEaten += food.Quantity;
                Weight += food.Quantity * 0.1;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}
