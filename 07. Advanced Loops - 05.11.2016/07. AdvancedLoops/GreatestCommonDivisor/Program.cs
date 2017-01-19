using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            var c = 0;
            var d = 0;

            do
            {
                a = a / 2;
                b = b / 2;
                d = d + 1;  
            } while (a == b);

            do
            {
                if (a %2 == 0)
                {
                    a = a / 2;
                }
                else if (b % 2 == 0)
                {
                    b = b / 2;
                }
                else if (a > b)
                {
                    a = (a - b) / 2;
                }
                else
                {
                    b = (b - a) / 2;
                }
            } while (a != b);
            c = a;
            Console.WriteLine("{0}, {1}",c , d);

        }
    }
}
