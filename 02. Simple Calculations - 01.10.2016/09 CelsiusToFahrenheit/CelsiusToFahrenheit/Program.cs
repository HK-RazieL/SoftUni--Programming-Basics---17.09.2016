using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = decimal.Parse(Console.ReadLine());
            decimal fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine(Math.Round(fahrenheit, 2));

        }
    }
}
