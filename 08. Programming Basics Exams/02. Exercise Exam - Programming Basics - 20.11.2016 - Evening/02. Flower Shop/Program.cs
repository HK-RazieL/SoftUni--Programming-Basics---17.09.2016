using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var magnolias = int.Parse(Console.ReadLine());
            var zombiuls = int.Parse(Console.ReadLine());
            var roses = int.Parse(Console.ReadLine());
            var cactus = int.Parse(Console.ReadLine());
            var giftPrice = double.Parse(Console.ReadLine());

            var magnoliasPrice = 3.25;
            var zombiulsPrice = 4.0;
            var rosePrice = 3.5;
            var cactusPrice = 8.0;

            var flowersPrice = (magnolias * magnoliasPrice) + (zombiuls * zombiulsPrice) + (roses * rosePrice) + (cactus * cactusPrice);
            var tax = flowersPrice * 0.05;

            if (flowersPrice >= giftPrice)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor((flowersPrice - tax) - giftPrice));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(giftPrice - (flowersPrice - tax)));
            }
        }
    }
}
