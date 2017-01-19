using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var middle = '*' + new string('/', (n * 2) - 2) + '*' + new string(' ', n) + '*' + new string('/', (n * 2) - 2) + '*';
            middle = middle.Replace(" ", "|");

            Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));

            if (n == 3 || n < 3)
            {
                Console.WriteLine(middle);
            }
            else if(n > 3 && n <= 100)
            {
                for (int i = 0; i < n - 3; i++)
                {
                    if (i == (n - 1) / 2 - 1)
                    {
                        Console.WriteLine(middle);
                    }
                    Console.WriteLine('*' + new string('/', (n * 2) - 2) + '*' + new string(' ', n) + '*' + new string('/', (n * 2) - 2) + '*');
                }
            }

            Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
        }
    }
}
