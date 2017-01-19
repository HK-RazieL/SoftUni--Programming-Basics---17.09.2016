using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = decimal.Parse(Console.ReadLine());
            string firstCurrency = (string)Console.ReadLine();
            string secondCurrency = (string)Console.ReadLine();
            var BGN = 1;
            var USD = 1.79549m;
            var EUR = 1.95583m;
            var GBP = 2.53405m;
            if (firstCurrency == "BGN" && secondCurrency == "USD")
            {
                Console.WriteLine("{0:N2}",(amount / USD));
            }
            else if (firstCurrency == "BGN" && secondCurrency == "EUR")
            {
                Console.WriteLine("{0:N2}", (amount / EUR));
            }
            else if (firstCurrency == "BGN" && secondCurrency == "GBP")
            {
                Console.WriteLine("{0:N2}", (amount / GBP));
            }
            else if (firstCurrency == "USD" && secondCurrency == "BGN")
            {
                Console.WriteLine("{0:N2}",(amount * USD));
            }
            else if (firstCurrency == "USD" && secondCurrency == "EUR")
            {
                Console.WriteLine("{0:N2}",((amount * USD) / EUR));
            }
            else if (firstCurrency == "USD" && secondCurrency == "GBP")
            {
                Console.WriteLine("{0:N2}", ((amount * USD) / GBP));
            }
            else if (firstCurrency == "EUR" && secondCurrency == "BGN")
            {
                Console.WriteLine("{0:N2}", (amount * EUR));
            }
            else if (firstCurrency == "EUR" && secondCurrency == "USD")
            {
                Console.WriteLine("{0:N2}", ((amount * EUR) / GBP));
            }
            else if (firstCurrency == "EUR" && secondCurrency == "GBP")
            {
                Console.WriteLine("{0:N2}", ((amount * EUR) / GBP));
            }
            else if (firstCurrency == "GBP" && secondCurrency == "BGN")
            {
                Console.WriteLine("{0:N2}", (amount * GBP));
            }
            else if (firstCurrency == "GBP" && secondCurrency == "USD")
            {
                Console.WriteLine("{0:N2}", ((amount * GBP) / USD));
            }
            else if (firstCurrency == "GBP" && secondCurrency == "EUR")
            {
                Console.WriteLine("{0:N2}", ((amount * GBP) / EUR));
            }

        }
    }
}
