using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You have entered a dungeon and in front of you is a mighty knight!");
            Console.WriteLine("Would you like to attack the knight? (y/n)");
            Random damage = new Random();
            var decision = Console.ReadLine();
            
            if (decision == "y")
            {
                int hit = damage.Next(1, 20);
                Console.WriteLine("You hit the knight for {0} damage", hit);
                if (hit > 10)
                {
                    Console.WriteLine("You defeated the knight, you win!");
                }
                else
                {
                    Console.WriteLine("You were not strong enough so you only hit for {0}, you have lost the battle", hit);
                }

            }
            else if (decision == "n")
            { 
                Console.WriteLine("You decided to avoid the battle, pussy...");
            }
            Console.ReadLine();
            
        }
    }
}