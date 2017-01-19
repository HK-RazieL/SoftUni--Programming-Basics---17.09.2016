using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = int.Parse(Console.ReadLine());

            switch (test)
            {
                case 1:
                    Console.WriteLine("works");
                    break;
                default:
                    Console.WriteLine("fail");
                    break;
            }
        }
    }
}
