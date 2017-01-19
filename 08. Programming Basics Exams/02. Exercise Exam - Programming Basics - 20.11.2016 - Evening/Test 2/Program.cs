using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallestRoom = double.Parse(Console.ReadLine());
            var kitchen = double.Parse(Console.ReadLine());
            var pricePerMeter = double.Parse(Console.ReadLine());

            var bathroom = smallestRoom / 2;
            var secondRoom = smallestRoom + (smallestRoom * 0.1);
            var thirdRoom = secondRoom + (secondRoom * 0.1);
            var coridor = (thirdRoom + secondRoom + bathroom + smallestRoom + kitchen) * 0.05;

            Console.WriteLine("{0:f2}", (thirdRoom + secondRoom + bathroom + smallestRoom + kitchen + coridor) * pricePerMeter);
        }
    }
}
