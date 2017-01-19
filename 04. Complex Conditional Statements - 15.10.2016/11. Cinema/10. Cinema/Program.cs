using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var numberOfRows = int.Parse(Console.ReadLine());
            var numberOfColumns = int.Parse(Console.ReadLine());
            var price = 0.0;
            var totalPrice = 0.0;
            switch (type)
            {
                case "Premiere":
                    price = 12.00;
                    break;
                case "Normal":
                    price = 7.5;
                    break;
                case "Discount":
                    price = 5.0;
                    break;
                default:
                    break;
            }
            totalPrice = price * numberOfColumns * numberOfRows;
            Console.WriteLine($"{totalPrice:f2} leva");
        }
    }
}
