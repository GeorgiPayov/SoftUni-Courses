using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {
                List<Person> person = new List<Person>();
                List<Product> product = new List<Product>();

                string[] persons = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < persons.Length; i++)
                {
                    string[] onePerson = persons[i].Split("=");
                    string name = onePerson[0];
                    int money = int.Parse(onePerson[1]);


                    Person newPerson = new Person(name, money, new List<string>());
                    person.Add(newPerson);
                }


                string[] products = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < products.Length; i++)
                {
                    string[] oneProduct = products[i].Split("=");
                    string name = oneProduct[0];
                    int cost = int.Parse(oneProduct[1]);

                    Product newProduct = new Product(name, cost);
                    product.Add(newProduct);
                }


                string[] input = Console.ReadLine().Split();

                while (input[0] != "END")
                {
                    string customer = input[0];
                    string productBuy = input[1];

                    foreach (var human in person)
                    {
                        foreach (var stock in product)
                        {
                            if (human.Name == customer && stock.Name == productBuy)
                            {
                                if (human.Money - stock.Cost < 0)
                                {
                                    Console.WriteLine($"{human.Name} can't afford {stock.Name}");
                                }
                                else
                                {
                                    Console.WriteLine($"{human.Name} bought {stock.Name}");
                                    human.BagOfProducts.Add(stock.Name);
                                    human.Money -= stock.Cost;
                                }
                            }

                        }
                    }

                    input = Console.ReadLine().Split();
                }

                foreach (var item in person)
                {
                    if (item.BagOfProducts.Count < 1)
                    {
                        Console.WriteLine($"{item.Name} - Nothing bought");
                    }
                    else
                    {
                        Console.WriteLine($"{item.Name} - {string.Join(", ", item.BagOfProducts)}");
                    }
                    
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
