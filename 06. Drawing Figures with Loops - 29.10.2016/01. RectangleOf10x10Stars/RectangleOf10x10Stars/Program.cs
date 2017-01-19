using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleOf10x10Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var stars = int.Parse(Console.ReadLine());

            for (int i = 1; i <= stars; i++)
            {
                Console.WriteLine("**********");
            }
        }
    }
}
