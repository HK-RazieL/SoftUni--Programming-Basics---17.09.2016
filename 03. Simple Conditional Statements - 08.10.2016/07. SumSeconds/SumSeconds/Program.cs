using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstContender = int.Parse(Console.ReadLine());
            var secondContender = int.Parse(Console.ReadLine());
            var thirdContender = int.Parse(Console.ReadLine());

            var totalTime = firstContender + secondContender + thirdContender;
            var minutes = totalTime / 60;
            var seconds = totalTime % 60;

            if (seconds < 10)
            {
                Console.WriteLine(minutes + ":0" + seconds);
            }
            else
            {
                Console.WriteLine(minutes + ":" + seconds);
            }
        }
    }
}
