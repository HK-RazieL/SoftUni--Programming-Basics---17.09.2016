using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var day = Console.ReadLine();
            var amount = double.Parse(Console.ReadLine());
            var price = 0d;


            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = amount * 2.5;
                        break;
                    case "apple":
                        price = amount * 1.2;
                        break;
                    case "orange":
                        price = amount * 0.85;
                        break;
                    case "grapefruit":
                        price = amount * 1.45;
                        break;
                    case "kiwi":
                        price = amount * 2.7;
                        break;
                    case "pineapple":
                        price = amount * 5.5;
                        break;
                    case "grapes":
                        price = amount * 3.85;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                Console.WriteLine("{0:F2}", price);

            }
            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = amount * 2.7;
                        break;
                    case "apple":
                        price = amount * 1.25;
                        break;
                    case "orange":
                        price = amount * 0.90;
                        break;
                    case "grapefruit":
                        price = amount * 1.6;
                        break;
                    case "kiwi":
                        price = amount * 3;
                        break;
                    case "pineapple":
                        price = amount * 5.6;
                        break;
                    case "grapes":
                        price = amount * 4.2;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                Console.WriteLine("{0:F2}", price);

            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
