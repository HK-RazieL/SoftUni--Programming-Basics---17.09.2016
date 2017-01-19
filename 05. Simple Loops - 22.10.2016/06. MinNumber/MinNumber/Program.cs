using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var min = int.MaxValue;

            for (int i = 0; i < number; i++)
            {
                var numberToCheck = int.Parse(Console.ReadLine());
                if (numberToCheck <= min)
                {
                    min = numberToCheck;
                }
            }
            Console.WriteLine(min);
        }
    }
}
