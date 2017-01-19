using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var totalFoodLeft = int.Parse(Console.ReadLine());

            var dogFoodPerDayKg = double.Parse(Console.ReadLine());
            var catFoodPerDayKg = double.Parse(Console.ReadLine());
            var turtleFoodPerDayGr = double.Parse(Console.ReadLine());

            var foodRequired = days * (dogFoodPerDayKg + catFoodPerDayKg + (turtleFoodPerDayGr / 1000));
            var foodLeft = Math.Floor(totalFoodLeft - foodRequired);

            if (totalFoodLeft >= foodRequired)
            {

                Console.WriteLine("{0} kilos of food left.", Math.Abs(foodLeft));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Abs(foodLeft));
            }





        }
    }
}
