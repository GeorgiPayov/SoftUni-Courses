using System;
using System.Linq;

namespace _3.Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] webs = Console.ReadLine().Split();

            foreach (string num in numbers)
            {
                if (num.Length < 10)
                {
                    Stationary stationary = new Stationary(num);
                    Console.WriteLine($"{stationary.Calling()} {num}");
                }
                else
                {
                    Smartphone smartphone = new Smartphone(num);
                    Console.WriteLine($"{smartphone.Calling()} {num}");
                }
            }

            foreach (string web in webs)
            {
                bool containsInt = web.Any(char.IsDigit);

                if (!containsInt)
                {
                    Smartphone smartphone = new Smartphone(web);
                    Console.WriteLine($"{smartphone.Browsing()} {web}!");
                }
                else
                {
                    Console.WriteLine("Invalid URL!");
                }
            }

        }
    }
}
