using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestThingy
{
    class Program
    {
        static void Main(string[] args)
        {
            Random damage = new Random();
            var hit = damage.Next();
            int thingyHit = damage.Next(3, 4);
            int thingyHealth = 20;
            int health = 15;

            Console.WriteLine("Welcome to this random thingy, would you be using a sword or a mace for your adventure?");
            bool weaponChosen = false;
            while (!weaponChosen)
            {
               string weapon = Console.ReadLine();
                switch (weapon)
                {
                    case "sword":
                        hit = damage.Next(4, 6);
                        weaponChosen = true;
                        Console.WriteLine("You have chosen {0} as your tool to spread pleasantness!", weapon);
                        break;
                    case "mace":
                        hit = damage.Next(3, 8);
                        weaponChosen = true;
                        Console.WriteLine("You have chosen {0} as your tool to spread pleasantness!", weapon);
                        break;
                    default:
                        Console.WriteLine("Please select sword... or mace... you dumbo...");
                        weaponChosen = false;
                        break;
                }
            }

            Console.WriteLine("\n You have entered a dungeon (naturally) and in front of you stands a mighty thingy!");
            Console.WriteLine("The thingy has 20 health and you only have 15");

            while (health > 0 && thingyHealth > 0)
            {
                Console.WriteLine("Would you like to attack the thingy? (y/n)");

                var battle = Console.ReadLine();

                switch (battle)
                {
                    case "y":
                        Console.WriteLine("You swing at the thingy and hit it for {0} damage.", hit);
                        thingyHealth = thingyHealth - hit;
                        if (health > 0)
                        {
                            Console.WriteLine("After your attack the thingy now has {0} health left!", thingyHealth);
                        }
                        health = health - thingyHit;
                        if (thingyHealth > 0)
                        {
                            Console.WriteLine("The thingy hit you for {0} damage and you are left with {1} health!", thingyHit, health);
                        }
                        if (thingyHealth <= 0)
                        {
                            Console.WriteLine("You have defeated the thingy!", hit);
                            Console.WriteLine("You Win!");
                            Console.WriteLine();
                            Console.WriteLine("After an insane adventure that took years and years to complete, you finally defeaterd... something... I guess...");
                            Console.WriteLine("To Be Continued... Maybe...");
                            Console.ReadLine();

                        }
                        else if (health <= 0)
                        {
                            Console.WriteLine("Your health has reached 0, you died a miserable death!");
                            Console.WriteLine("You Lose!");
                        }
                        break;
                    case "n":
                        Console.WriteLine("You decided to run away, you pussy...");
                        Console.WriteLine("You Lose");
                        return;
                    default:
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}



