using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape = Console.ReadLine();
            var sideA = 0.0;
            var sideB = 0.0;
            var radius = 0.0;
            var height = 0.0;
            
            if(shape == "square")
            {
                sideA = double.Parse(Console.ReadLine());
            }
            else if (shape == "rectangle")
            {
                sideA = double.Parse(Console.ReadLine());
                sideB = double.Parse(Console.ReadLine());
            }
            else if (shape == "circle")
            {
                radius = double.Parse(Console.ReadLine());
            }
            else if (shape == "triangle")
            {
                sideA = double.Parse(Console.ReadLine());
                height = double.Parse(Console.ReadLine());
            }

            if (shape == "square")
            {
                Console.WriteLine("{0:F3}", sideA * sideA);
            }
            else if (shape == "rectangle")
            {
                Console.WriteLine("{0:F3}", sideA * sideB);
            }
            else if (shape == "circle")
            {
                Console.WriteLine("{0:F3}", Math.PI * (Math.Pow(radius, 2)));
            }
            else if (shape == "triangle")
            {
                Console.WriteLine("{0:F3}",(sideA * height) / 2);
            }
        }
    }
}
