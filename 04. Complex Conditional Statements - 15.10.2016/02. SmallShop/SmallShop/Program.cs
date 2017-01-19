using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var city = Console.ReadLine();
            var quantity = decimal.Parse(Console.ReadLine());

            var totalPrice = 0m;

            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    totalPrice = quantity * 0.5m;
                }
                else if (product == "water")
                {
                    totalPrice = quantity * 0.8m;
                }
                else if (product == "beer")
                {
                    totalPrice = quantity * 1.2m;
                }
                else if (product == "sweets")
                {
                    totalPrice = quantity * 1.45m; ;
                }
                else if (product == "peanuts")
                {
                    totalPrice = quantity * 1.6m;
                }
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    totalPrice = quantity * 0.4m;
                }
                else if (product == "water")
                {
                    totalPrice = quantity * 0.7m;
                }
                else if (product == "beer")
                {
                    totalPrice = quantity * 1.15m;
                }
                else if (product == "sweets")
                {
                    totalPrice = quantity * 1.30m; ;
                }
                else if (product == "peanuts")
                {
                    totalPrice = quantity * 1.5m;
                }
            }
            else if (city == "Varna")
            {
                if (product == "coffee")
                {
                    totalPrice = quantity * 0.45m;
                }
                else if (product == "water")
                {
                    totalPrice = quantity * 0.70m;
                }
                else if (product == "beer")
                {
                    totalPrice = quantity * 1.10m;
                }
                else if (product == "sweets")
                {
                    totalPrice = quantity * 1.35m; ;
                }
                else if (product == "peanuts")
                {
                    totalPrice = quantity * 1.55m;
                }
            }
            Console.WriteLine(totalPrice);
        }
    }
}
