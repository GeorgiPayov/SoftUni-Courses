using System;
using System.Collections.Generic;

namespace Border_Control
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Citizen> citizen = new List<Citizen>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] input = command.Split();

                if (input.Length > 2)
                {
                    string name = input[0] + input[1];
                    int id = int.Parse(input[2]);
                    Citizen person = new Citizen(name, id);
                    citizen.Add(person);
                }
                else
                {
                    string name = input[0];
                    int id = int.Parse(input[1]);
                    Citizen person = new Citizen(name, id);
                    citizen.Add(person);
                }

                command = Console.ReadLine();
            }

            int fakeId = int.Parse(Console.ReadLine());

            foreach (var person in citizen)
            {
                Console.WriteLine(person.Id);
            }
        }
    }
}
