using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalNumbers = int.Parse(Console.ReadLine());
            var sumNumbers = 0;
            int numbers = 0;
            var biggestNumber = 0;


            for (var i = 0; i < totalNumbers; i++)
            {
                numbers = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    biggestNumber = numbers;
                }
                else if (numbers > biggestNumber)
                {
                    biggestNumber = numbers;
                }
                sumNumbers = sumNumbers + numbers;

            }
            var diff = sumNumbers - (2* biggestNumber);

            if (sumNumbers - (2 * biggestNumber) == 0)
            {
                Console.WriteLine("Yes Sum = {0}", sumNumbers - biggestNumber);
            }
            else if (sumNumbers - (sumNumbers - (2 * biggestNumber)) != 0)
            {
                Console.WriteLine("No Diff = {0}", Math.Abs(diff));
            }
        }
    }
}
