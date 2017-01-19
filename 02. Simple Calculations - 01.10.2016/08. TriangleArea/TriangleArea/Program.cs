using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var side = decimal.Parse(Console.ReadLine());
            var height = decimal.Parse(Console.ReadLine());
            decimal area = side * height / 2;
            Console.WriteLine(Math.Round(area, 2));
        }
    }
}
