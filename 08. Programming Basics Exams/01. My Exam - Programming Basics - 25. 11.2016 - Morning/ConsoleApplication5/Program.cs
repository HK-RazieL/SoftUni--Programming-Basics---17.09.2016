using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            var skumriqPrice = double.Parse(Console.ReadLine());
            var cacaPrice = double.Parse(Console.ReadLine());
            var kgPalamud = double.Parse(Console.ReadLine());
            var kgSafrid = double.Parse(Console.ReadLine());
            var kgClam = int.Parse(Console.ReadLine());

            var clamPrice = kgClam * 7.5;
            var palamudPrice = (skumriqPrice + (skumriqPrice * 0.6)) * kgPalamud;
            var safridPrice = (cacaPrice + (cacaPrice * 0.8)) * kgSafrid;

            Console.WriteLine("{0:f2}", palamudPrice + safridPrice + clamPrice);



        }
    }
}
