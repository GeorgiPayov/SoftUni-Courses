using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {
                List<Animal> animals = new List<Animal>();

                string type = Console.ReadLine();

                while (type != "Beast!")
                {
                    string[] animalInfo = Console.ReadLine().Split();

                    string name = animalInfo[0];
                    int age = int.Parse(animalInfo[1]);
                    string gender = animalInfo[2];

                    if (type == "Cat")
                    {
                        Cat cat = new Cat(name, age, gender);
                        animals.Add(cat);
                    }
                    else if (type == "Dog")
                    {
                        Dog dog = new Dog(name, age, gender);
                        animals.Add(dog);
                    }
                    else if (type == "Frog")
                    {
                        Frog frog = new Frog(name, age, gender);
                        animals.Add(frog);
                    }
                    else if (type == "Tomcat")
                    {
                        Cat tomcat = new Tomcat(name, age);
                        animals.Add(tomcat);
                    }
                    else if (type == "Kitten")
                    {
                        Cat kitten = new Kitten(name, age);
                        animals.Add(kitten);
                    }

                    type = Console.ReadLine();
                }

                foreach (var animal in animals)
                {
                    Console.WriteLine(animal.GetType().Name);
                    Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                    Console.WriteLine(animal.ProduceSound());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
