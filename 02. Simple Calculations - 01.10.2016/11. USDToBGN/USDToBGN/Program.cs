using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDToBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var leva = decimal.Parse(Console.ReadLine());
            var dollar = leva * 1.79549m;
            Console.WriteLine(Math.Round(dollar, 2));
        }
    }
}