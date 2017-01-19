using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            double deg = (180 / Math.PI) * rad;
            Console.WriteLine(Math.Round(deg, 2));
        }
    }
}
