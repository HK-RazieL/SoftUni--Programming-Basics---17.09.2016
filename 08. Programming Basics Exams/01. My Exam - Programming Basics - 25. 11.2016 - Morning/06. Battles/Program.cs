using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPlayer = int.Parse(Console.ReadLine());
            var secondPlayer = int.Parse(Console.ReadLine());
            var maxBattles = int.Parse(Console.ReadLine());

            var first = 0;
            var second = 0;
            var battles = 0;

            for (first = 1; first <= firstPlayer; first++)
            {
                
                for (second = 1; second <= secondPlayer; second++)
                {


                    if (battles >= maxBattles)
                    {
                        break;
                    }
                    Console.Write($" ({first}" + " <-> " + $"{second})" );
                    battles++;          
                }

            }
        }
    }
}
