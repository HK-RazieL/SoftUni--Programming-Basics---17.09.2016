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
            var evenNumbers = 0;
            var oddNumbers = 0;

            for (int i = 0; i < numbers; i++)
            {
                var totalNumbers = int.Parse(Console.ReadLine());
                if (totalNumbers % 2 == 0)
                {
                    evenNumbers = evenNumbers + totalNumbers;
                }
                else if (totalNumbers % 2 == 1)
                {
                    oddNumbers = oddNumbers + totalNumbers;
                }
            }


            if (evenNumbers == oddNumbers)
            {
                Console.WriteLine("Yes, sum = {0}", evenNumbers);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Max(evenNumbers, oddNumbers) - Math.Min(evenNumbers, oddNumbers));
            }
        }
    }
}
