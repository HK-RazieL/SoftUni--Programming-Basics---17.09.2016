using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var output = Console.ReadLine();

            var meters = 0d;
            var outputLength = 0d;

            if (input == "mm")
            {
                meters = length / 1000;
            }
            else if (input == "cm")
            {
                meters = length / 100;
            }
            else if (input == "mi")
            {
                meters = length / 0.000621371192;
            }
            else if (input == "in")
            {
                meters = length / 39.3700787;
            }
            else if (input == "km")
            {
                meters = length / 0.001;
            }
            else if (input == "ft")
            {
                meters = length / 3.2808399;
            }
            else if (input == "yd")
            {
                meters = length / 1.0936133;
            }
            else if (input == "m")
            {
                meters = length;
            }

            if (output == "mm")
            {
                outputLength = meters * 1000;
            }
            else if (output == "cm")
            {
                outputLength = meters * 100;
            }
            else if (output == "mi")
            {
                outputLength = meters * 0.000621371192;
            }
            else if (output == "in")
            {
                outputLength = meters * 39.3700787;
            }
            else if (output == "km")
            {
                outputLength = meters * 0.001;
            }
            else if (output == "ft")
            {
                outputLength = meters * 3.2808399;
            }
            else if (output == "yd")
            {
                outputLength = meters * 1.0936133;
            }
            else if (output == "m")
            {
                outputLength = meters;
            }

            Console.WriteLine(outputLength + " " + output);
        }
    }
}
