using System;

namespace _2.Raiding
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfPower = 0;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                if (type == "Druid")
                {
                    BaseHero druid = new Druid(name, 80);
                    Console.WriteLine(druid.CastAbility());
                    sumOfPower += 80;
                }
                else if (type == "Paladin")
                {
                    BaseHero paladin = new Paladin(name, 100);
                    Console.WriteLine(paladin.CastAbility());
                    sumOfPower += 100;
                }
                else if (type == "Rogue")
                {
                    BaseHero rogue = new Rogue(name, 80);
                    Console.WriteLine(rogue.CastAbility());
                    sumOfPower += 80;
                }
                else if (type == "Warrior")
                {
                    BaseHero warrior = new Warrior(name, 100);
                    Console.WriteLine(warrior.CastAbility());
                    sumOfPower += 100;
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }
            }

            int boss = int.Parse(Console.ReadLine());

            if (boss <= sumOfPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
