using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            var price = 0.0;

            if (distance < 20)
            {
                switch (timeOfDay)
                {
                    case "day":
                            price = (0.79 * distance) + 0.7;
                            break;
                    case "night":
                            price = (0.9 * distance) + 0.7;
                            break;
                    default:
                        break;
                }
            }
            else if (distance >= 20 && distance < 100)
            {
                price = 0.09 * distance;
            }
            else if (distance >= 100)
            {
                price = 0.06 * distance;
            }

            Console.WriteLine($"{price:F2}");
        }
    }
}
