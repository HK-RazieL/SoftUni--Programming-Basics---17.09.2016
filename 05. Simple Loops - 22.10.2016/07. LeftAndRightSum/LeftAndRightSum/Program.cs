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
            var sumLeft = 0;
            var sumRight = 0;
            for (int i = 0; i < numbers; i++ )
            {
                var leftNumbers = int.Parse(Console.ReadLine());
                sumLeft = sumLeft + leftNumbers;
            }

            for (int i = 0; i < numbers; i++)
            {
                var rightNumbers = int.Parse(Console.ReadLine());
                sumRight = sumRight + rightNumbers;
            }
            
            if(sumLeft == sumRight)
            {
                Console.WriteLine("Yes, sum = {0}", sumLeft);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Max(sumLeft, sumRight) - Math.Min(sumLeft, sumRight));
            }


        }
    }
}
