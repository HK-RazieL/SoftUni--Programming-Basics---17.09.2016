using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int leftEar = 1; leftEar <= n; leftEar++)
            {
                for (int i = 1; i <= leftEar; i++)
                {
                    Console.Write("*");
                }
                Console.Write("\\");
                var middle = new string('-', n * 2 - leftEar * 2 + 1);
                Console.Write(middle);
                Console.Write("/");

                for (int i = 1; i <= leftEar; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            for (int leftEye = 1; leftEye <= 3; leftEye++)
            {
                Console.Write("|");
                for (int j = 1; j <= leftEye; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\\");

                for (int j = n; j <= n / 2 + 1; j-=2)
                {
                    var middle = new string('*', n);
                    Console.Write(middle);
                }
                
                Console.Write("/");

                for (int i = 1; i <= leftEye; i++)
                {
                    Console.Write("*");
                }
                Console.Write("|");
                Console.WriteLine();
            }


            for (int bottom = 1; bottom <= n; bottom++)
            {
                for (int i = 1; i <= bottom; i++)
                {
                    Console.Write("-");
                }
                Console.Write("\\");
                var middle = new string('*', n * 2 - bottom * 2 + 1);
                Console.Write(middle);
                Console.Write("/");

                for (int i = 1; i <= bottom; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
        }
    }
}
