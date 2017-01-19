using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            var score = int.Parse(Console.ReadLine());
            var points = 0.0;

            if (score <= 100)
            {
                points = 5;
            }
            else if(score > 100 && score < 1000)
            {
                points = (score * 20 / 100.0);
            }
            else if(score > 1000)
            {
                points = (score * 10 / 100.0);
            }

            if (score % 2 == 0)
            {
                points += 1;
            }

            if (score % 10 == 5)
            {
                points += 2;
            }
            Console.WriteLine(points);
            Console.WriteLine(score + points);
        }
    }
}
