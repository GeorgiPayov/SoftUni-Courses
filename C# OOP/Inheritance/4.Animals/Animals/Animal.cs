using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return name; }
            set 
            { 
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set 
            { 
                //if (age < 0)
                //{
                //    Exception();
                //}
                age = value;
            }
        }

        public string Gender
        {
            get { return gender; }
            set 
            { 
                //if (value != "Male" || value != "Female")
                //{
                //    Exception();
                //}
                gender = value; 
            }
        }


        public virtual string ProduceSound() 
        {
            return "";
        }
        
        //public void Exception()
        //{
        //    throw new ArgumentException("Invalid input!");
        //}
    }
}
