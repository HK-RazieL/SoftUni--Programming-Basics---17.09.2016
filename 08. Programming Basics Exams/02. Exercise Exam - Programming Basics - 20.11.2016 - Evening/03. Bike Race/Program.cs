using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var juniors = int.Parse(Console.ReadLine());
            var seniors = int.Parse(Console.ReadLine());
            var trace = Console.ReadLine();

            var juniorTax = 0.0;
            var seniorTax = 0.0;

            switch (trace)
            {
                case "trail":
                    juniorTax = 5.5;
                    seniorTax = 7.0;
                    break;
                case "cross-country":
                    juniorTax = 8.0;
                    seniorTax = 9.5;
                    if (juniors + seniors >= 50 )
                    {
                        juniorTax = 8.0 * 0.75;
                        seniorTax = 9.5 * 0.75;
                    }
                    break;
                case "downhill":
                    juniorTax = 12.25;
                    seniorTax = 13.75;
                    break;
                case "road":
                    juniorTax = 20.0;
                    seniorTax = 21.5;
                    break;
                default:
                    break;
            }

            var totalTax = (juniors * juniorTax) + (seniors * seniorTax);
            var wareNtare = totalTax * 0.05;

            Console.WriteLine("{0:F2}", totalTax - wareNtare);
        }
    }
}
