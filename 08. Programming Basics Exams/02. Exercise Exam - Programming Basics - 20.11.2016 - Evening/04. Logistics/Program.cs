using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = int.Parse(Console.ReadLine());

            var microbus = 0.0;
            var truck = 0.0;
            var train = 0.0;

            var weight = 0.0;
            for (int i = 1; i <= items; i++)
            {
                weight = int.Parse(Console.ReadLine());

                if (weight <= 3)
                {
                    microbus += weight;
                }
                else if (weight > 3 && weight <= 11)
                {
                    truck += weight;
                }
                else if (weight > 11)
                {
                    train += weight;
                }
            }

            var totalWeight = microbus + truck + train;
            var averagePricePerTon = (microbus * 200 + truck * 175 + train * 120) / totalWeight;
            var microbusPercentage = (microbus / totalWeight) * 100.0;
            var truckPercentage = (truck / totalWeight) * 100.0;
            var trainPercentage = (train / totalWeight) * 100.0;

            Console.WriteLine("{0:f2}", averagePricePerTon);
            Console.WriteLine("{0:f2}%", microbusPercentage);
            Console.WriteLine("{0:f2}%", truckPercentage);
            Console.WriteLine("{0:f2}%", trainPercentage);
            
        }
    }
}