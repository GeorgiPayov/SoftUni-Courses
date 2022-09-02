using System;
using System.Collections.Generic;

namespace _3.WildFarm
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<IAnimal> animals = new List<IAnimal>();
            IAnimal animal = null;
            IFood food = null;

            while (input != "End")
            {
                string[] inputInfo = input.Split();
                string type = inputInfo[0];
                string name = inputInfo[1];
                double weight = double.Parse(inputInfo[2]);

                string[] fruitInfo = Console.ReadLine().Split();
                string typeF = fruitInfo[0];
                int quantity = int.Parse(fruitInfo[1]);

                if (type is "Cat" || type is "Tiger")
                {                            
                    string livingRegion = inputInfo[3];
                    string breed = inputInfo[4];

                    if (type is "Cat")
                    {
                        animal = new Cat(name, weight, 0, livingRegion, breed);
                    }
                    else
                    {
                        animal = new Tiger(name, weight, 0, livingRegion, breed);
                    }

                }
                else if (type is "Owl" || type is "Hen")
                {
                    double wingSize = double.Parse(inputInfo[3]);
                    if (type is "Owl")
                    {
                        animal = new Owl(name, weight, 0, wingSize);
                    }
                    else
                    {
                        animal = new Hen(name, weight, 0, wingSize);
                    }
                }
                else if (type is "Dog" || type is "Mouse")
                {
                    string livingRegion = inputInfo[3];
                    if (type is "Dog")
                    {
                        animal = new Dog(name, weight, 0, livingRegion);
                    }
                    else
                    {
                        animal = new Mouse(name, weight, 0, livingRegion);
                    }
                }

                if (typeF is "Vegetable")
                {
                    
                    food = new Vegetable(quantity);
                }
                else if (typeF is "Fruit")
                {

                    food = new Fruit(quantity);
                }
                else if (typeF is "Meat")
                {

                    food = new Meat(quantity);
                }
                else if (typeF is "Seeds")
                {

                    food = new Seeds(quantity);
                }

                Console.WriteLine(animal.ProduceSound());
                animal.Eat(food);
                animals.Add(animal);
                input = Console.ReadLine();
            }

            foreach (var anima in animals)
            {
                Console.WriteLine(anima.ToString());
            }
        }
    }
}
