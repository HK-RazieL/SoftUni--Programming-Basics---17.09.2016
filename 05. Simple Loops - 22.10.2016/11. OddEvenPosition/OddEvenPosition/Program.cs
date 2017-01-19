using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = int.Parse(Console.ReadLine());
            var sumEven = 0;
            var sumOdd = 0;

            for (int i = 0; i < numbers; i++)
            {
                var totalNumbers = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEven += totalNumbers;
                }
                else if (i % 2 != 0)
                {
                    sumOdd += totalNumbers;
                }
            }


            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes, sum = {0}", sumEven);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(sumEven - sumOdd));
            }
        }
    }
}
