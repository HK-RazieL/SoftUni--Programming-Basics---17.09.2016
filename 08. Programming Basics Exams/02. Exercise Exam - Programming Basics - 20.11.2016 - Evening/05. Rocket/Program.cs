using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var leftSide = (n * 3 / 2) - 1;
            var middle = n * 2 - 2;
            var blanks = 0;

            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine(new string('.', leftSide) + '/' + new string(' ', blanks) + '\\' + new string('.', leftSide));
                leftSide--;
                blanks+=2;
            }

            var head = new string('.', n / 2) + new string('*', n * 2) + new string('.', n / 2);
            Console.WriteLine(head);

            for (int row = 1; row <= n * 2; row++)
            {
                var body = new string('.', n / 2) + '|' + new string('\\', middle) + '|' + new string('.', n / 2);
                Console.WriteLine(body);
            }


            var tail = new string('.', n / 2) + '/' + new string('*', middle) + '\\' + new string('.', n / 2);
            Console.WriteLine(tail);


            var tailMiddle = middle;

            for (int row = 1; row <= n / 2 - 1; row++)
            {
                tailMiddle += 2;
                var tailLeftSide = new string('.', leftSide) + '/' + new string('*', tailMiddle) + '\\' + new string('.', leftSide);
                Console.WriteLine(tailLeftSide);
                leftSide--;
                
            }

        }
    }
}
