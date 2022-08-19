using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private int money;
        private string name;
        private List<string> bagOfProducts;

        public Person(string name, int money, List<string> bagOfProducts)
        {
            this.Name = name;
            this.Money = money;
            this.BagOfProducts = bagOfProducts;
        }

        public string Name 
        {
            get
            {
                return name;
            }

            set
            {
                if (value == null)
                {
                    throw new Exception("Name cannot be empty");
                }
                name = value;
            }
        }

        public int Money 
        {
            get
            {
                return money;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }
                money = value;
            }
        }

        public List<string> BagOfProducts { get; set; }

    }
}
